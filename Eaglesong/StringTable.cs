using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaglesong
{
    public class StringTable : IEnumerable
    {
        public readonly float MaxEntries;
        public readonly int NumEntries;
        public readonly string Name;
        public readonly int UserDataSize;
        public readonly int UserDataSizeBits;
        public readonly bool UserDataFixedSize;
        public readonly int Flags;

        private const int KeyHistorySize = 32;
        private const int MaxNameLength = 0x400;
        private Dictionary<int, StringTableRow> Rows;

        public StringTable(dota2.CSVCMsg_CreateStringTable msg)
        {
            this.MaxEntries = msg.max_entries;
            this.NumEntries = msg.num_entries;
            this.Name = msg.name;
            this.UserDataSize = msg.user_data_size;
            this.UserDataSizeBits = msg.user_data_size_bits;
            this.UserDataFixedSize = msg.user_data_fixed_size;
            this.Flags = msg.flags;

            this.Create(msg.string_data);
        }

        private void Create(byte[] string_data)
        {
            BitStream stream = new BitStream(string_data);

            int bitsPerIndex = (int)Math.Log(this.MaxEntries / Math.Log(2));
            KeyHistory keyHistory = new KeyHistory();

            Dictionary<int, StringTableRow> map = new Dictionary<int, StringTableRow>();

            bool mysteryFlag = stream.ReadBool();

            int index = -1;
            while (map.Count < this.NumEntries)
            {
                // figure out if we are consecutive indexing or not
                if (stream.ReadBool())
                {
                    index++;
                }
                else
                {
                    index = stream.ReadBits(bitsPerIndex);
                }

                string name = "";
                if (stream.ReadBool())
                {
                    if (mysteryFlag && stream.ReadBool())
                    {
                        throw new InvalidDataException("There's a problem with the Mystery Flags.");
                    }
                    // check if we're referencing the key history
                    if (stream.ReadBool())
                    {
                        // the index of the key in history they we're using
                        int basis = stream.ReadBits(5);
                        // the number of characters from the history key to use
                        int length = stream.ReadBits(5);

                        if (basis > keyHistory.Length)
                        {
                            // the key requested is invalid, so just use the data provided
                            name += stream.ReadString(StringTable.MaxNameLength);
                        }
                        else
                        {
                            string s = keyHistory[basis];
                            if (length > s.Length)
                            {
                                name += s + stream.ReadString(StringTable.MaxNameLength);
                            }
                            else
                            {
                                // just use the first n characters of the history string and get the rest of the string from the stream
                                /*
                                 * i.e.
                                 * keyHistory[basis] == "cfg/cpu_level_0_pc.txt"
                                 * length = 14
                                 * name = "cfg/cpu_level_" + *read stream* (i.e. "1_pc.txt")
                                 */
                                name += s.Substring(0, length) + stream.ReadString(StringTable.MaxNameLength - length);
                            }
                        }
                    }
                    else
                    {
                        name += stream.ReadString(StringTable.MaxNameLength);
                    }
                    // add the key to the history
                    keyHistory.Push(name);
                }

                // read the inner value
                byte[] value = null;
                if (stream.ReadBool()) {
                    int bitLength = 0;
                    if (this.UserDataFixedSize)
                    {
                        bitLength = this.UserDataSizeBits;
                    }
                    else
                    {
                        bitLength = stream.ReadBits(14) * 8;
                    }

                    value = stream.ReadBytes(bitLength);
                }
                map[index] = new StringTableRow(name, value);
            }

            this.Rows = map;
        }

        public void Update(dota2.CSVCMsg_UpdateStringTable msg)
        {
            // TODO
        }

        private class KeyHistory
        {
            /// <summary>
            /// The hidden backing array
            /// </summary>
            private string[] arr;

            /// <summary>
            /// The pointer to the end of the history
            /// </summary>
            private int ptr = 0;

            public int Length { get; private set; }

            public KeyHistory()
            {
                this.arr = new string[StringTable.KeyHistorySize];
                this.Length = 0;
            }

            /// <summary>
            /// Pushes a new key onto the end, clobbering the oldest key if out of space
            /// </summary>
            /// <param name="s"></param>
            public void Push(string s)
            {
                this.arr[ptr] = s;

                ptr = (ptr + 1) % StringTable.KeyHistorySize;

                this.Length = Math.Min(this.Length + 1, StringTable.KeyHistorySize);
            }

            /// <summary>
            /// Gets or sets the key at the given index
            /// </summary>
            /// <param name="i"></param>
            /// <returns></returns>
            public string this[int i] {
                get
                {
                    return this.arr[this.GetIndex(i)];
                }
                set
                {
                    this.arr[this.GetIndex(i)] = value;
                }
            }

            /// <summary>
            /// Gets the hidden index for the given external index
            /// </summary>
            /// <param name="i"></param>
            /// <returns></returns>
            private int GetIndex(int i)
            {
                if (i > this.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                if (this.Length < StringTable.KeyHistorySize)
                {
                    return i;
                }
                else
                {
                    return (StringTable.KeyHistorySize + (this.ptr + i)) % StringTable.KeyHistorySize;
                }
            }
        }

        public StringTableRow this[int i]
        {
            get
            {
                return this.Rows[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.Rows.GetEnumerator();
        }

        public override string ToString()
        {
            return String.Format("[StringTable(\"{0}\", {1})", this.Name, this.Rows.Count);
        }
    }

    public class StringTableRow
    {
        public string Name { get; private set; }
        public byte[] Value { get; private set; }

        public StringTableRow(string name, byte[] value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            int len = 0;
            if (this.Value != null)
            {
                len = this.Value.Length;
            }
            return String.Format("[StringTableRow(\"{0}\", {1})]", this.Name, len);
        }
    }
}
