// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int a = Promt("Введите первое число >");
int b = Promt("Введите второе число >");
int multi = 1;

for (int i = 0; i <= b; i++)
{
    if (i == 0)
    {
        multi = 1;
    }
    else
    {
        if (i == 1)
        {
            multi = a;
        }
        else
        {
            multi = multi * a;
        }
    }
}

System.Console.WriteLine(multi);