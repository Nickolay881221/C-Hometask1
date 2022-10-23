// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int Promt(string message) // функция записи в переменную введенного целого числа для ввода количества чисел
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Numbers(int len) // заполнение массива введенными числами
{
int [] Array = new int[len];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
return Array;
}

void PrintArray(int[] Arr) // функция печати массива для проверки
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"{Arr[i]} ");
    }
}

int Positive(int[] Arr) //функция подсчета положительных элементов массива
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int m = Promt("Введите количество чисел для ввода >");
System.Console.WriteLine("Введите случайные положительные/отрицательные числа >");
int[] Arr = Numbers(m);
PrintArray(Arr);
int count = Positive(Arr);
System.Console.WriteLine();
System.Console.WriteLine($"количество положительных чисел > {count}");
