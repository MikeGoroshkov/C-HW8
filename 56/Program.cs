/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

Main();

void Main()
{
    int[,] matrix = GetArray(5, 5, 0, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] arr = SummRowElements(matrix);
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine(FindIndexMin(arr));
}

int[] SummRowElements(int[,] matr)
{
    int[] result = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            result[i] += matr[i, j];
        }
    }
    return result;
}

int FindIndexMin(int[] array)
{
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[indexMin]) { indexMin = i; }
    }
    return indexMin;
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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}