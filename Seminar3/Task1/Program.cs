// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
        number = number/10;
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

int number = Promt("Введите пятизначное число >");

int[] num1 = NuminArray(number);

if (num1.Length != 5)
{
    System.Console.WriteLine("Введено не пятизначное число");
}
else
{
    if (num1[0] == num1[4] && num1[1] == num1[3])
    {
        System.Console.WriteLine("Введеное число палиндром");
    }
    else
    {
        System.Console.WriteLine("Введеное число не палиндром");
    }
}

// int count = 0;
//     while (count < num1.Length)
//     {
//         System.Console.WriteLine(num1[count]);
//         count = count + 1;
//     }