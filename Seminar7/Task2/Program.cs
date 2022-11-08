// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


int[,] RanMatrix(int m, int n) // заполнение массива случайными значениями типа Double
{
    int[,] Array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = rnd.Next(-10, 11);
        }
    }
    return Array;
}

void SearchNum(int[,] Array, int m, int n) // поиск элемента
{
    int count = 1;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                System.Console.WriteLine(Array[i,j]);
                count++;
            }
        }
    }
    if (count == 1)
    {
        System.Console.WriteLine("Искомого элемента нет");
    }
}

void PrintArray(int[,] Arr) // функция печати массива
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            System.Console.Write($"{Arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine($"введите размеренность массива: 2 числа - количество строк и количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] Array = RanMatrix(m,n);
PrintArray(Array);
System.Console.WriteLine("введите позицию элемента в массиве");
int k = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
SearchNum(Array, k, l);
