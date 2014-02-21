using System;

class MatrixUI
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(3, 3);
        matrix1[0,0] = 1; matrix1[0,1] = 2; matrix1[0,2] = 0;
        matrix1[1,0] = 0; matrix1[1,1] = 1; matrix1[1,2] = 1;
        matrix1[2,0] = 2; matrix1[2,1] = 0; matrix1[2,2] = 1;

        Matrix matrix2 = new Matrix(3, 3);
        matrix2[0,0] = 1; matrix2[0,1] = 2; matrix2[0,2] = 1;
        matrix2[1,0] = 2; matrix2[1,1] = 2; matrix2[1,2] = 2;
        matrix2[2,0] = 2; matrix2[2,1] = 1; matrix2[2,2] = 1;

        Console.WriteLine("First Matrix is:");
        Console.WriteLine(matrix1);

        Console.WriteLine("Second Matrix is:");
        Console.WriteLine(matrix2);

        Console.WriteLine("Аccumulation (m1+m2) of the Matrices:");
        Console.WriteLine(matrix1 + matrix2);

        Console.WriteLine("Subtraction of the Matrices:");
        Console.WriteLine(matrix1 - matrix2);

        Console.WriteLine("Multiplication of the Matrices:");
        Console.WriteLine(matrix1 * matrix2); 
    }
    
}
