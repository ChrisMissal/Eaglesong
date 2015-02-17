using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaglesong
{
    class StringTable
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

        public StringTable(dota2.CSVCMsg_CreateStringTable msg)
        {
            this.MaxEntries = msg.max_entries;
            this.NumEntries = msg.num_entries;
            this.Name = msg.name;
            this.UserDataSize = msg.user_data_size;
            this.UserDataSizeBits = msg.user_data_size_bits;
            this.UserDataFixedSize = msg.user_data_fixed_size;
            this.Flags = msg.flags;
        }

        private void Create(byte[] string_data)
        {
            BitStream stream = new BitStream(string_data);

            int bitsPerIndex = (int)Math.Log(this.MaxEntries / Math.Log(2));
            List<string> keyHistory = new List<string>(32);
            int keyHistoryCount = 0;

            Dictionary<int, string> map = new Dictionary<int, string>();

            bool mysteryFlag = stream.ReadBool();

            int index = 0;
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
                        int basis = stream.ReadBits(5);
                        int length = stream.ReadBits(5);

                        if (basis > keyHistoryCount)
                        {
                            // the key requested is invalid, so just use the 
                            name += stream.ReadString(StringTable.MaxNameLength);
                        }
                        else
                        {
                            string s = keyHistory[basis];
                        }
                    }
                    else
                    {
                        name += stream.ReadString(StringTable.MaxNameLength);
                    }
                }
            }
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
                    return (this.ptr + i - 1) % StringTable.KeyHistorySize;
                }
            }
        }
    }
}
