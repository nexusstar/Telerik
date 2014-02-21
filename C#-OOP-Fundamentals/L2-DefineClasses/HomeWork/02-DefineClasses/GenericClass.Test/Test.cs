using System.Collections.Generic;
using System;
namespace GenericClass.Test
{
    class Test
    {
        static void Main()
        {
            //create instance
            GenericList<int> genericList = new GenericList<int>();

            //add elements
            for (int i = 0; i < 16; i++)
            {
                genericList.Add(i);
            }

            Console.WriteLine(genericList);

            //remove elements
            for (int i = 0; i < 5; i++)
            {
                genericList.RemoveAt(i);
            }

            Console.WriteLine(genericList);

            //insert at position
            genericList.Insert(1, 32);
            genericList.Insert(16, 1);

            Console.WriteLine(genericList);

            //Find min and max
            Console.WriteLine(genericList.Min());
            Console.WriteLine(genericList.Max());

            Console.WriteLine(genericList.Count);
            Console.WriteLine(genericList.Capacity);

            //clear
            genericList.Clear();

            Console.WriteLine(genericList.Count);
            Console.WriteLine(genericList.Capacity);
        }
    }
}
