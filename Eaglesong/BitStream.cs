using System;
using System.Collections;
using System.IO;

namespace Eaglesong
{
    /// <summary>
    /// A stream-esque wrapper around a BitArray
    /// </summary>
    class BitStream
    {
        /// <summary>
        /// The bits in the stream
        /// </summary>
        private BitArray Bits { get; set; }

        /// <summary>
        /// The current position
        /// </summary>
        private int Position { get; set; }

        /// <summary>
        /// The hidden function used in the ReadBits processor to determine the bit order
        /// </summary>
        private readonly Func<int, int, int> _indexToBitPos;
        
        public BitStream(byte[] bytes)
        {
            this.Bits = new BitArray(bytes);
            this.Position = 0;

            // we need to reverse the bit order for our bit reader if the machine isn't little endian.
            this._indexToBitPos = delegate(int count, int index)
            {
                return index;
            };
            if (!BitConverter.IsLittleEndian)
            {
                this._indexToBitPos = delegate(int count, int index)
                {
                    return count - index - 1;
                };
            }
        }

        /// <summary>
        /// Reads in the specified number of bits and converts the bits to an int
        /// </summary>
        /// <param name="bitCount"></param>
        /// <returns></returns>
        public int ReadBits(int bitCount)
        {
            var res = 0;
            for (var i = 0; i < bitCount; i++) {
                res |= (this.Bits[this.Position++] ? 1 : 0) << i;
            }
            return res;
        }

        /// <summary>
        /// Reads in the specified 
        /// </summary>
        /// <param name="bitCount"></param>
        /// <returns></returns>
        public byte[] ReadBytes(int bitCount)
        {
            var ret = new byte[Math.Max(bitCount / 8, 1)];
            var bitsRead = 0;
            for (var i = 0; i < ret.Length; i++)
            {
                ret[i] = 0;
                int max = Math.Min(8, bitCount - bitsRead);
                for (var j = 0; j < max; j++)
                {
                    bitsRead++;
                    ret[i] |= (byte) ((this.Bits[this.Position++] ? 1 : 0) << this._indexToBitPos(8, j));
                }
            }

            return ret;
        }

        /// <summary>
        /// Reads in the specified number of bytes and converts the bytes to a string, it will stop reading if it encounters a null byte
        /// </summary>
        /// <param name="byteCount">the number of bytes to read (not bits)</param>
        /// <returns></returns>
        public string ReadString(int byteCount)
        {
            var res = "";

            for (var i = 0; i < byteCount; i++)
            {
                int b = this.ReadBits(8);
                if (b == 0)
                {
                    break;
                }
                res += (char)b;
            }

            return res;
        }

        /// <summary>
        /// Reads in a single bit as a bool
        /// </summary>
        /// <returns></returns>
        public bool ReadBool()
        {
            return this.Bits[this.Position++];
        }

        /// <summary>
        /// Seeks through the stream relative to the origin
        /// </summary>
        /// <param name="bitOffset"></param>
        /// <param name="origin"></param>
        public void Seek(long bitOffset, SeekOrigin origin)
        {
            long start = 0;
            switch (origin)
            {
                case SeekOrigin.Begin:
                    start = 0;
                    break;

                case SeekOrigin.Current:
                    start = this.Position;
                    break;

                case SeekOrigin.End:
                    start = this.Bits.Length;
                    break;
            }

            var newPos = (int)(start + bitOffset);
            if (newPos > this.Bits.Length)
            {
                throw new ArgumentException("Seeking greater than stream length.");
            }

            this.Position = newPos;
        }
    }
}
