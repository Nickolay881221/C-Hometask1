// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int EnterNumber(string msg)
{
    Console.Write(msg + ">");
    return int.Parse(Console.ReadLine());
}

int m = EnterNumber("Введите первое число (M)");
int n = EnterNumber("Введите второе число (N)");

void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    
        System.Console.WriteLine(m);
        PrintNumbers(m + 2, n);
}

if (m % 2 == 0)
{
    PrintNumbers(m, n);
}
else
{
    PrintNumbers(m + 1, n);
}


