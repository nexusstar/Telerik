namespace MobilePhone
{
    using System;

    class Program
    {
        public static void Main()
        {
            //test the GSMClass (ex 1 - 7)
            GSMTest.Test();

            Console.WriteLine("\nGSM CallManager Test:\n");

            //Test the GSMCallHistory (ex 8 -12)
            GSMCallHistoryTest.Test();
        }
    }
}
