/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

Main();

void Main()
{
    int[,,] array = GetVarious3DArray(2, 2, 2);
    Print3DArrayWithIndex(array);
}

int[,,] GetVarious3DArray(int m, int n, int p)
{
    int[,,] result = new int[m, n, p];
    int s = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                result[i, j, k] = s;
                s += 1;
            }
        }
    }
    return result;
}

void Print3DArrayWithIndex(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}