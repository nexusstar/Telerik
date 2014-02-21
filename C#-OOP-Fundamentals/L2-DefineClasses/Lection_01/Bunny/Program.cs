namespace Bunny
{
    using System;
    using NumeralSystem;
    using System.Collections.Generic;
    public class Program
    {
        static void Main(string[] args)
        {
            Aircraft Aircraft = new Aircraft();
            Aircraft.Fuel = 100M;

            Aircraft boing = new Aircraft();
            boing.Fuel = 150M;

            Console.WriteLine(Aircraft);
            Console.WriteLine(boing.Fuel);

            Console.WriteLine(Aircraft.Weight);
            Console.WriteLine(NumeralSystem.ToDecimal(15M, 2));

            Point pt = new Point();
            pt.X = 5;
            pt.Y = 10;
            pt.Z = 12;

            Point secondPoint = new Point(1, 2, 3);
            Console.WriteLine(secondPoint);
            List<int> someList = new List<int>();
            Stack<int> someStack = new Stack<int>();

        }
    }
}
