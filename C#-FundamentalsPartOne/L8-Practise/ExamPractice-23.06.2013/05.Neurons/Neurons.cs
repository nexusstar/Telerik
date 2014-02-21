using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Neurons
{
    static void Main()
    {
        while (true)
        {
            string givenNumber = Console.ReadLine();
            if (givenNumber == "-1")
            {
                break;
            }

            string binNumber = Convert.ToString(long.Parse(givenNumber), 2);
            char[] binArray = binNumber.ToCharArray(); //convert to array
            int firstLeft = Array.IndexOf(binArray, '1');
            int lastRight = Array.LastIndexOf(binArray, '1');
            string result = "";
            for (int i = firstLeft; i < lastRight; i++)
            {
                result = result + (binArray[i] == '1' ? '0' : '1');
            }
            result = result.PadRight(binArray.Length, '0');
            Console.WriteLine(Convert.ToInt32(result, 2));
        }

    }
}

