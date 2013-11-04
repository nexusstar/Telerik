using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIItable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                char letter = (char)i;
                Console.WriteLine("to number {0} corresponds {1}",i , letter);
            }
        }
    }
}
