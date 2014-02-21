using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrNumber = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNumber[i] = int.Parse(arr[i]);
            }

            int CurrentIndex = 0;
            int loopStart = -1;
            bool[] visited = new bool[n];
            StringBuilder result = new StringBuilder();
            result.Append(' ');

            while (true)
            {
                if (CurrentIndex < 0 || CurrentIndex >= n)
                {
                    break;
                }
                if (visited[CurrentIndex])
                {
                    loopStart = CurrentIndex;
                    break;
                }
                result.Append(CurrentIndex);
                result.Append(' ');
                visited[CurrentIndex] = true;
                CurrentIndex = arrNumber[CurrentIndex];
            }
            if (loopStart >= 0)
            {
                int index = result.ToString().IndexOf(" " + loopStart + " ");
                if (index == 0)
                {
                    result[0] = '(';
                }
                else
                {
                    result[index] = '(';
                }
                result[result.Length - 1] = ')';

            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
