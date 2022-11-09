// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void AverageColumn(int[,] Arr)// функция поиска среднего по колонкам и вывода на экран
{
    
    for (int i = 0; i < Arr.GetLength(1); i++)
    {
        double Average = 0.0;
        int Count = 0;
        for (int j = 0; j < Arr.GetLength(0); j++)
        {
            Average = Average + Arr[j, i];
            Count++;
        }
        System.Console.Write($"{Math.Round(Average/Count,1)}\t");
    }
}
System.Console.WriteLine($"введите размеренность массива: 2 числа - количество строк и количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] Array = RanMatrix(m,n);
PrintArray(Array);
AverageColumn(Array);