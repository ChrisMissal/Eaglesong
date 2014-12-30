using System;
using System.Collections;

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
        /// Reads in the specified number of bits and converts the bits to a string
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public string ReadString(int count)
        {
            string res = "";

            int b = 0, bpos = 0;
            for (int i = 0; i < count; i++)
            {
                if (i % 8 == 0)
                {
                    res += Convert.ToChar(b);
                    b = 0;
                    bpos = 7;
                }

                b |= (this.Bits[this.Position++] ? 1 : 0) << bpos--;
            }

            return res;
        }
    }
}
