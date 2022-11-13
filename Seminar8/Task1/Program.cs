// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.


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

int[,] DecreasingInRows(int [,] Arr)
{   
    for (int i = 0; i < Arr.GetLength(0); i++)
    
    {
        for (int j = 0; j < Arr.GetLength(1)-1; j++)
        
        {
            int max = 0;
            for (int k = 0; k < Arr.GetLength(1)-1; k++)
            {
                if (Arr[i, k] < Arr[i, k + 1] )
                {
                    max = Arr[i, k + 1];
                    Arr[i, k + 1] = Arr[i, k];
                    Arr[i, k] = max;
                }        
            }
        }
    }
    return Arr;
}


int[,] newArray = CreateMatrix(4, 4, -10, 10);
PrintArray(newArray);
DecreasingInRows(newArray);
System.Console.WriteLine();
PrintArray(newArray);