/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

Main();

void Main()
{
    int[,] array = GetArray(7, 7, 0, 99);
    PrintArray(array);
    Console.WriteLine();
    SortRows(array);
    PrintArray(array);
}

void SortRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }
        }
    }
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

void PrintArray(int[,] matr)
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