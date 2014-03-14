namespace _05.LongBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class BitArray64 : IEnumerable<int>
    {
        private const int ArrayCapacity = 64;
        private ulong number;

        public BitArray64(object longNum)
        {
            ulong test;
            if (ulong.TryParse(longNum.ToString(), out test))
            {
                this.Number = test;
            }
            else
            {
                throw new ArgumentException("This is not ulong number");
            }
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = ArrayCapacity - 1; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArr = obj as BitArray64;

            if ((object)bitArr == null)
            {
                return false;
            }

            if (!Object.Equals(this.Number, bitArr.Number))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ ArrayCapacity;
        }

        public int this[int index]
        {
            get
            {
                if (index > ArrayCapacity - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException("Index must be in range 0-63.");
                }

                ulong mask = ((ulong)1) << index;
                ulong bitOnPosition = (this.Number & mask) >> index;
                
                return (int)bitOnPosition;
                
            }
        }

        public static bool operator ==(BitArray64 one, BitArray64 two)
        {
            return Object.Equals(one, two);
        }

        public static bool operator !=(BitArray64 one, BitArray64 two)
        {
            return !Object.Equals(one, two);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = ArrayCapacity - 1; i >= 0; i--)
            {
                result.Append(this[i]);
            }

            return result.ToString();
        }
    }
}