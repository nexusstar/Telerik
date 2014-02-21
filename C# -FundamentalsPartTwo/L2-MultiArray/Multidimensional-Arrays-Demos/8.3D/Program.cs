using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] matrix = {
                    {
                    {1,2,3},
                    {4,5,6}
                    },   
                    {
                        {7,8,9},
                        {10,11,12}
                    }  
                       };
            for (int dim = 0; dim < matrix.GetLength(0); dim++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    for (int col = 0; col < matrix.GetLength(2); col++)
                    {
                        Console.WriteLine({});
                    }
                }
            }
        }
        
    }
}
