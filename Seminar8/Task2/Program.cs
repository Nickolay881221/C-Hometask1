// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int row, int column, int min, int max) // создание массива, заданной длины, со случайными значениями в заданном диапазоне
{
    int[,] Array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return Array;
}

void PrintArray(int[,] Arr) // вывод матрицы для проверки
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            System.Console.Write($"{Arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SearchMin(int[] Arr) // поиск индекса наименьшего элемента в одномерном массиве

{
    int min = Arr[0];
    int index = 0;
    for (int i = 1; i < Arr.Length; i++)
    {
        if (min > Arr[i])
        {
            index = i;
        }
    }
    return index;
}

void MinSumAmongRows(int [,] Arr) //поиск строки с наименьшей суммой элементов
{   
    int[] sum = new int[Arr.GetLength(1)];
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        
        {
            sum[i] += Arr[i, j];
        }
    }
    System.Console.WriteLine("Суммы значений в строках массива по порядку:>");
    PrintArrayRow(sum);
    System.Console.WriteLine();
    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов {SearchMin(sum)}");
}

void PrintArrayRow(int[] Arr) // функция печати массива для проверки
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"{Arr[i]} ");
    }
}

int[,] newArray = CreateMatrix(4, 4, -10, 10);
PrintArray(newArray);
System.Console.WriteLine();
MinSumAmongRows(newArray);

