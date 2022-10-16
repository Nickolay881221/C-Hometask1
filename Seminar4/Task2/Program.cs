// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Promt(string message) // функция записи в переменную введенного целого числа
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] NuminArray(int multinumber) // функция для преобразования числа в массив, независимо от количества цифр в числе
{
    int number = multinumber;
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count = count + 1;
    }
    int[] array = new int[count];
    while (count > 0)
    {
        count = count - 1;
        array[count] = multinumber % 10;
        multinumber = multinumber / 10;

    }
    return array;
}

int number = Promt("Введите число >");

int[] num1 = NuminArray(number);
int sum = 0;

for (int i = 0; i < num1.Length; i++)
{
    sum = sum + num1[i];
}

System.Console.WriteLine(sum);