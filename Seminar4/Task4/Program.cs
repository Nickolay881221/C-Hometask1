// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

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

int[] Array = RandomArray();
int max = 0;
int secondMax = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (max < Array[i])
    {
        secondMax = max;
        max = Array[i];
    }
    else if (secondMax < Array[i] && secondMax != max) 
    {
        secondMax = Array[i];
    }
}

System.Console.WriteLine($"Максимально число {max}");
System.Console.WriteLine($"Второе максимально число {secondMax}");
