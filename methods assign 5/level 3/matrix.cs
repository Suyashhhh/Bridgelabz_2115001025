using System;

class MatrixOperations
{
    public static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            }
        }
        return matrix;
    }

    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        int[,] result = new int[rows1, cols2];
        if (cols1 != rows2)
        {
            throw new InvalidOperationException("Matrix dimensions do not match for multiplication.");
        }
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }

    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    public static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    public static int[,] Inverse2x2(int[,] matrix)
    {
        int det = Determinant2x2(matrix);
        if (det == 0) throw new InvalidOperationException("Matrix is not invertible.");
        int[,] result = new int[2, 2];
        result[0, 0] = matrix[1, 1] / det;
        result[0, 1] = -matrix[0, 1] / det;
        result[1, 0] = -matrix[1, 0] / det;
        result[1, 1] = matrix[0, 0] / det;
        return result;
    }

    public static double[,] Inverse3x3(int[,] matrix)
    {
        double det = Determinant3x3(matrix);
        if (det == 0) throw new InvalidOperationException("Matrix is not invertible.");
        double[,] result = new double[3, 3];
        result[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / det;
        result[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / det;
        result[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / det;
        result[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / det;
        result[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / det;
        result[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / det;
        result[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / det;
        result[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / det;
        result[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / det;
        return result;
    }

    public static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    public static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3:F2} ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int rows = 3, cols = 3;
        int[,] matrix1 = CreateRandomMatrix(rows, cols);
        int[,] matrix2 = CreateRandomMatrix(rows, cols);
        
        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);
        
        Console.WriteLine("Addition of matrices:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));
        
        Console.WriteLine("Subtraction of matrices:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));
        
        Console.WriteLine("Multiplication of matrices:");
        DisplayMatrix(MultiplyMatrices(matrix1, matrix2));
        
        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));
        
        Console.WriteLine("Determinant of 2x2 Matrix (Matrix 1):");
        Console.WriteLine(Determinant2x2(matrix1));
        
        Console.WriteLine("Determinant of 3x3 Matrix (Matrix 1):");
        Console.WriteLine(Determinant3x3(matrix1));
        
        Console.WriteLine("Inverse of 2x2 Matrix (Matrix 1):");
        DisplayMatrix(Inverse2x2(matrix1));
        
        Console.WriteLine("Inverse of 3x3 Matrix (Matrix 1):");
        DisplayMatrix(Inverse3x3(matrix1));
    }
}

