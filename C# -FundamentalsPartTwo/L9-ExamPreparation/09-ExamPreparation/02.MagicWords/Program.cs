using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MagicWords
{
    class MagicWordsTask
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int newPosition = currentWord.Length % (words.Count + 1);
                words.Insert(newPosition, currentWord);
                if (newPosition < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }
            StringBuilder result = new StringBuilder();
            int maxLength = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (maxLength < words[i].Length)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (i < words[j].Length)
                    {
                        result.Append(words[j][i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
