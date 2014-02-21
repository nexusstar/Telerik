using System;
using System.Collections.Generic;
using System.Linq;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine(); //"2228";
        int buls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        int[] secretArray = Array.ConvertAll(secretNumber.ToString().ToArray(), x => (int)x - 48);
        //int[] guessArray = Array.ConvertAll(guessNumber.ToString().ToArray(), x => (int)x - 48);

        //int[,] matrix = new int[2, 4]{
        //    {secretArray[0],secretArray[1],secretArray[2], secretArray[3]},
        //    {guessArray[0], guessArray[1], guessArray[2], guessArray[3] }
        //};
        List<int> resultList = new List<int>();
        for (int count = 1111; count <= 9999; count++)
        {
            int[] guessArray = Array.ConvertAll(count.ToString().ToArray(), x => (int)x - 48);
            int[,] matrix = new int[2, 4]{
                {secretArray[0],secretArray[1],secretArray[2], secretArray[3]},
                {guessArray[0], guessArray[1], guessArray[2], guessArray[3] }
            };
            int tempBull = 0;
            int tempCow = 0;
            //check all the bulls
            for (int col = 0; col < 4; col++)
            {
                if (matrix[0, col] == matrix[1, col])
                {
                    tempBull++;
                    matrix[1, col] = 0;
                    matrix[0, col] = 0;
                }
            }
            //check all the cows for 3
            if (matrix[0, 3] == matrix[1, 0] && matrix[0, 3] != 0)
            {
                tempCow++;
                matrix[1, 0] = 0;
            }
            else if (matrix[0, 3] == matrix[1, 1] && matrix[0, 3] != 0)
            {
                tempCow++;
                matrix[1, 1] = 0;
            }
            else if (matrix[0, 3] == matrix[1, 2] && matrix[0, 3] != 0)
            {
                tempCow++;
                matrix[1, 2] = 0;
            }
            //check all the cows for 2
            if (matrix[0, 2] == matrix[1, 0] && matrix[0, 2] != 0)
            {
                tempCow++;
                matrix[1, 0] = 0;
            }
            else if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] != 0)
            {
                tempCow++;
                matrix[1, 1] = 0;
            }
            else if (matrix[0, 2] == matrix[1, 3] && matrix[0, 2] != 0)
            {
                tempCow++;
                matrix[1, 3] = 0;
            }
            //check all the cows for 1
            if (matrix[0, 1] == matrix[1, 0] && matrix[0, 1] != 0)
            {
                tempCow++;
                matrix[1, 0] = 0;
            }
            else if (matrix[0, 1] == matrix[1, 2] && matrix[0, 1] != 0)
            {
                tempCow++;
                matrix[1, 2] = 0;
            }
            else if (matrix[0, 1] == matrix[1, 3] && matrix[0, 1] != 0)
            {
                tempCow++;
                matrix[1, 3] = 0;
            }
            //check all the cows for 0
            if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] != 0)
            {
                tempCow++;
                matrix[1, 0] = 0;
            }
            else if (matrix[0, 0] == matrix[1, 2] && matrix[0, 0] != 0)
            {
                tempCow++;
                matrix[1, 2] = 0;
            }
            else if (matrix[0, 0] == matrix[1, 3] && matrix[0, 0] != 0)
            {
                tempCow++;
                matrix[1, 3] = 0;
            }
            int[] tempArray = Array.ConvertAll(count.ToString().ToArray(), x => (int)x - 48);

            if (tempCow == cows && tempBull == buls && tempArray[1] != 0 && tempArray[2] != 0 && tempArray[3] != 0)
            {
                resultList.Add(count);

            }

        }
        if (resultList.Count > 0)
        {

            foreach (var item in resultList)
            {
                Console.Write(item + " ");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
