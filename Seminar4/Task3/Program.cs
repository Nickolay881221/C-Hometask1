// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 7, 8

int[] RandomArray()

    {
        int[] NewArray = new int[8];
        for (int i = 0; i < NewArray.Length; i++)
        {
            NewArray[i] = new Random().Next(-999,999);
        }
        
        
        for (int j = 0; j < NewArray.Length; j++)
        {
            System.Console.Write($"{NewArray[j]} ");
        }

        return NewArray;
    }

RandomArray();