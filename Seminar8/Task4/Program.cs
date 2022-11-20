// * Напишите программу, которая заполнит спирально квадратный массив.

void PrintArray(int[,] Arr) // вывод матрицы для проверки
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            System.Console.Write($"{Arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateMatrix(int row, int column, int min, int max) // создание массива, заданной длины, со случайными значениями в заданном диапазоне
{
    int[,] Array = new int[row, column];
    Random rnd = new Random();
    for (int k = 0; k <= row % 2; k++)
    {
        for (int i = k; i < Array.GetLength(1) - 1 - k; i++)
        {
            Array[k, i] = rnd.Next(min, max + 1);
        }
        for (int j = k; j < Array.GetLength(0) - 1 - k; j++)
        {
            Array[j, Array.GetLength(1) - 1 - k] = rnd.Next(min, max + 1);
        }
        for (int i = Array.GetLength(1) - 1 - k; i > 0; i--)
        {
            Array[Array.GetLength(0) - 1 - k, i] = rnd.Next(min, max + 1);
        }
        for (int j = Array.GetLength(0) - 1 - k; j > 0; j--)
        {
            Array[j, k] = rnd.Next(min, max + 1);
        }
    }
    return Array;
}

int[,] TestMatrix = CreateMatrix(6, 6, 0, 9);
PrintArray(TestMatrix);