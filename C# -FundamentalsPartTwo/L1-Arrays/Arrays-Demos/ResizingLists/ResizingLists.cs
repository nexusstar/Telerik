using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResizingLists
{
    class ResizingLists
    {
        static void Main()
        {
            List<int> listOfInt = new List<int>();
            string consoleLine = Console.ReadLine();
            int n = int.Parse(consoleLine);

            string lineBreak = new string('-', 20);

            for (int i = 0; i < n + 1; i++)
            {
                var capacity = listOfInt.Capacity;
                var count = listOfInt.Count;
                Console.WriteLine("Total Capacity of the List: {0}\nused:{1}\n{2}",
                                    capacity, count, lineBreak);
                listOfInt.Add(i);
            }
            Console.WriteLine(listOfInt.Capacity);
        }
    }
}