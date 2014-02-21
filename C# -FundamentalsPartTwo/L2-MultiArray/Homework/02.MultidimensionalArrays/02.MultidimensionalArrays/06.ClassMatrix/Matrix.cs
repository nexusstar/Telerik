/*
* 6. *Write a class Matrix, to holds a matrix of integers. 
* Overload the operators for adding, subtracting and multiplying
* of matrices, indexer for accessing the matrix content and ToString().
*/

using System;
using System.Text;

class Matrix
{
    private int[,] matrix;
    
    //constructor
    public Matrix (int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    //Indexer
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    //Fields
    public int Rows
    {
        get 
        { 
            return this.matrix.GetLength(0);
        }
        
    }
    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }
    
    //Overload + operator
    public static Matrix operator +
        (Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows,first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }
    
    //Overload - operator
    public static Matrix operator -
        (Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    //Overload * operator
    public static Matrix operator *
        (Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] * second[row, col];
            }
        }
        return result;
    }
    
    // Override method ToString()
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result.AppendFormat("{0,4}", this.matrix[row, col]); 
            }
            result.AppendLine();
        }
        return result.ToString();

    }
   
}
