using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BooleanVariable
{
    class Program
    {
        static void Main()
        {
            bool isFemale;
            Console.Write("What is your gender (male/female): ");
            string myGender = Console.ReadLine();

            if (myGender == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }

            Console.WriteLine("Are you female: " + isFemale);
        }
    }
}
