// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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



int[,] matrixA = CreateMatrix(3, 3, 0, 5);
int[,] matrixB = CreateMatrix(3, 3, 0, 5);

int[,] MultiplikationMatrix(int[,] Arr1, int[,] Arr2)
{
    int[,] resultMatrix = new int[Arr1.GetLength(0), Arr2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = Arr1[i, 0] * Arr2[0, j] + Arr1[i, 1] * Arr2[1, j] + Arr1[i, 2] * Arr2[2, j];
        }
    }
    return resultMatrix;
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

PrintArray (matrixA);
System.Console.WriteLine();
PrintArray (matrixB);
System.Console.WriteLine();
int[,] resultmtx = MultiplikationMatrix(matrixA, matrixB);
PrintArray (resultmtx);