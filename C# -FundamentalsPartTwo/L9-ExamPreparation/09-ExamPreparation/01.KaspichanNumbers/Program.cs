using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KaspichanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kaspichan = new List<string>();
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                kaspichan.Add(ch.ToString());
            }
            for (char sm = 'a'; sm <= 'i'; sm++)
            {
                if (sm == 'i')
                {
                    for (char big = 'A'; big <= 'V'; big++)
                    {
                        kaspichan.Add(sm.ToString() + big.ToString());
                    }
                    break;
                }
                for (char big = 'A'; big <= 'Z'; big++)
                {
                    kaspichan.Add(sm.ToString() + big.ToString());
                }
            }
            ulong input = ulong.Parse(Console.ReadLine());
            string result = ConvertNumber(input, kaspichan);
            Console.WriteLine(result);
        }

        private static string ConvertNumber(ulong input, List<string> kaspichan)
        {
            StringBuilder result = new StringBuilder();
            do
            {
                ulong remainder = input % 256;
                string digit = kaspichan[(int)remainder];
                result.Insert(0, digit);
                input = input / 256;
            } while (input > 0);

            return result.ToString();
        }
    }
}
