// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int EnterNumber(string msg)
{
    Console.Write(msg + ">");
    return int.Parse(Console.ReadLine());
}

int m = EnterNumber("Введите первое число (M)");
int n = EnterNumber("Введите второе число (N)");

int SumNumbers(int m, int n)
{
    int sum = 0;
    if (m > n)
    {
        return 0;
    }

    return m + SumNumbers( m + 1, n);
}

System.Console.WriteLine(SumNumbers(m, n));
