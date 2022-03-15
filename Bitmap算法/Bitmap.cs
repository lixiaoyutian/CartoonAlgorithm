using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitmap算法
{
    public class Bitmap
    {
        private long[] words;
        private int size;
        public Bitmap()
        {

        }
        public Bitmap(int size)
        {
            this.size = size;
            this.words = new long[(getWordIndex(size - 1)) + 1];
        }

        public bool getBit(int bitIndex)
        {
            if (bitIndex < 0 || bitIndex > this.size)
            {
                throw new Exception();
            }
            int wordIndex = getWordIndex(bitIndex);
            return (this.words[wordIndex] & (1L << bitIndex)) != 0;
        }

        public void setBit(int bitIndex)
        {
            if (bitIndex < 0 || bitIndex > this.size)
            {
                throw new Exception();
            }
            int wordIndex = getWordIndex(bitIndex);
            words[wordIndex] |= (1L << bitIndex);
        }

        public int getWordIndex(int bitIndex)
        {
            return bitIndex >> 6;
        }
    }
}