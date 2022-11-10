/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

Main();

void Main()
{
    int[,] firstMatrix = GetArray(3, 3, 0, 9);
    PrintMatrix(firstMatrix);
    Console.WriteLine();
    int[,] secondMatrix = GetArray(3, 3, 0, 9);
    PrintMatrix(secondMatrix);
    Console.WriteLine();
    int[,] product = ProductMatrix(firstMatrix, secondMatrix);
    PrintMatrix(product);
}

int[,] ProductMatrix(int[,] a, int[,] b)
{
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            c[i, j] = 0;
            for (int k = 0; k < b.GetLength(0); k++)
            {
                c[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return c;
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}