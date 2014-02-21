using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zerg
{
    class ZergProblem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i+=4)
            {
                string currentDigit = input.Substring(i, 4);
            }
        }
        static int ConvertZergMessageToInt (string currentDigit)
        {
            switch (currentDigit)
            {
               case  "Rawr": return   0  ;
               case  "Rrrr": return   1  ;
               case  "Hsst": return   2  ;
               case  "Ssst": return   3  ;
               case  "Grrr": return   4  ;
               case  "Rarr": return   5  ;
               case  "Mrrr": return   6  ;
               case  "Psst": return   7  ;
               case  "Uaah": return   8  ;
               case  "Uaha": return   9  ;
               case  "Zzzz": return  10  ;
               case  "Bauu": return  11  ;
               case  "Djav": return  12  ;
               case  "Myau": return  13  ;
               case "Gruh":  return  14 ;
                
            }
        }
    }
}
