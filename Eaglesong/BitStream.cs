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
        public BitArray Bits { get; private set; }

        public int Position { get; private set; }

        public BitStream(byte[] bytes)
        {
            this.Bits = new BitArray(bytes);
            this.Position = 0;
        }

        /// <summary>
        /// Reads in the specified number of bits and converts the bits to an int
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public int ReadBits(int count)
        {
            int res = 0;
            for (int i = 0; i < count; i++) {
                res |= (this.Bits[this.Position++] ? 1 : 0) << (count - i - 1);
            }
            return res;
        }

        /// <summary>
        /// Reads in the specified number of bytes and converts the bytes to a string, it will stop reading if it encounters a null byte
        /// </summary>
        /// <param name="count">the number of bytes to read (not bits)</param>
        /// <returns></returns>
        public string ReadString(int count)
        {
            string res = "";

            int b = 0, bpos = 0;
            for (int i = 0; i < count; i++)
            {
                b = this.ReadBits(8);
                if (b == 0)
                {
                    break;
                }
                else
                {
                    res += (char)b;
                }
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
        /// <param name="offset"></param>
        /// <param name="origin"></param>
        public override void Seek(long offset, SeekOrigin origin)
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

            int newPos = (int)(start + offset);
            if (newPos > this.Bits.Length)
            {
                throw new ArgumentException("Seeking greater than stream length.");
            }

            this.Position = newPos;
        }
    }
}
