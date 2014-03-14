namespace _05.LongBitArray
{
    using System;

    class Test
    {
        static void Main()
        {
            BitArray64 bitOne = new BitArray64(123456);

            BitArray64 bitTwo = new BitArray64(88888888888);
            
            BitArray64 bitMaxValue = new BitArray64(ulong.MaxValue);

           
            Console.WriteLine(bitOne); //test toString() and compare to foreach
            foreach (var bit in bitOne)//test foreach
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine(bitTwo);
            Console.WriteLine(bitMaxValue); //test ulong max value

            Console.WriteLine(bitOne.Equals(bitTwo));

            Console.WriteLine(bitOne != bitTwo);
            
            Console.WriteLine(bitOne.GetHashCode());

            Console.WriteLine(bitTwo.GetHashCode()); 

        }
    }
}
