// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int EnterNumber(string msg)
{
    Console.Write(msg + ">");
    return int.Parse(Console.ReadLine());
}

int m = EnterNumber("Введите первое число (m)");
int n = EnterNumber("Введите второе число (n)");

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n ==0)
    {
        return AkkermanFunction(m-1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
    }
    return AkkermanFunction(m, n);
}

int result = AkkermanFunction(m, n);
System.Console.WriteLine($"Результат функции Аккермана при заданных параметрах > {result}");