// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] RanNumbers(int m, int n) // заполнение массива случайными значениями типа Double
{
    double[,] Array = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = Math.Round(rnd.NextDouble()*100,2);
        }
    }
    return Array;
}

void PrintArray(double[,] Arr) // функция печати массива
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
double[,] Array = RanNumbers(m, n);
PrintArray(Array);