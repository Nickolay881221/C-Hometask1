//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите трехначное число");
System.Console.WriteLine(number%100/10);