using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GreedyDwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valleys input
            string[] valleysInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] valleys = new int[valleysInput.Length];
            for (int i = 0; i < valleys.Length; i++)
            {
                valleys[i] = int.Parse(valleysInput[i]);
            }

            // Solution
            int patterns = int.Parse(Console.ReadLine());
            int maxCoins = int.MinValue;
            for (int i = 0; i < patterns; i++)
            {
                // Pattern input
                string[] currentPatternInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] pattern = new int[currentPatternInput.Length];
                for (int j = 0; j < pattern.Length; j++)
                {
                    pattern[j] = int.Parse(currentPatternInput[j]);
                }

                // Array for saving visited valleys
                bool[] visited = new bool[valleys.Length];

                // Collect coins from first valley
                int currentCoins = valleys[0];

                int currentValleyIndex = 0;
                int patternIndex = 0;

                // Mark first valley as visited
                visited[currentValleyIndex] = true;

                while (true)
                {
                    // If pattern index is out of range, start over.
                    if (patternIndex >= pattern.Length)
                    {
                        patternIndex = 0;
                    }

                    int nextValleyIndex = currentValleyIndex + pattern[patternIndex];

                    // Next valley index is in valleys range?
                    if (0 <= nextValleyIndex && nextValleyIndex < valleys.Length)
                    {
                        // Valley is visited?
                        if (!visited[nextValleyIndex])
                        {
                            // Collect valley coins
                            currentCoins += valleys[nextValleyIndex];

                            // Mark valley as visited
                            visited[nextValleyIndex] = true;

                            currentValleyIndex += pattern[patternIndex];
                            patternIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentCoins > maxCoins)
                {
                    maxCoins = currentCoins;
                }
            }

            // Output
            Console.WriteLine(maxCoins);
        }
    }
}
