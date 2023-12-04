using System;

public class MathOperations
{
    // Перевантажений метод для додавання двох чисел
    public static T Add<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

    // Перевантажений метод для віднімання двох чисел
    public static T Subtract<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }

    // Перевантажений метод для множення двох чисел
    public static T Multiply<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    // Перевантажений метод для додавання двох масивів чисел
    public static T[] Add<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Array sizes must be the same for addition.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Add(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод для віднімання двох масивів чисел
    public static T[] Subtract<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Array sizes must be the same for subtraction.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Subtract(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод для множення двох масивів чисел
    public static T[] Multiply<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Array sizes must be the same for multiplication.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Multiply(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод для додавання двох матриць
    public static T[,] Add<T>(T[,] matrixA, T[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        if (rows != matrixB.GetLength(0) || columns != matrixB.GetLength(1))
        {
            throw new ArgumentException("Matrix dimensions must be the same for addition.");
        }

        T[,] result = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Add(matrixA[i, j], matrixB[i, j]);
            }
        }
        return result;
    }

    // Перевантажений метод для віднімання двох матриць
    public static T[,] Subtract<T>(T[,] matrixA, T[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        if (rows != matrixB.GetLength(0) || columns != matrixB.GetLength(1))
        {
            throw new ArgumentException("Matrix dimensions must be the same for subtraction.");
        }

        T[,] result = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Subtract(matrixA[i, j], matrixB[i, j]);
            }
        }
        return result;
    }

    // Перевантажений метод для множення двох матриць
    public static T[,] Multiply<T>(T[,] matrixA, T[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int columnsB = matrixB.GetLength(1);

        if (columnsA != matrixB.GetLength(0))
        {
            throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix for multiplication.");
        }

        T[,] result = new T[rowsA, columnsB];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                T sum = default(T);
                for (int k = 0; k < columnsA; k++)
                {
                    sum = Add(sum, Multiply(matrixA[i, k], matrixB[k, j]));
                }
                result[i, j] = sum;
            }
        }
        return result;
    }
}