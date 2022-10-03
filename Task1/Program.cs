// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int Promt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int FirstNumber = Promt("Введите первое число >");
int SecondNumber = Promt("Введите второе число >");

if (FirstNumber > SecondNumber)
{
    System.Console.Write($"Число {FirstNumber} больше числа {SecondNumber}");
}
else if (SecondNumber > FirstNumber)
{
    System.Console.Write($"Число {SecondNumber} больше числа {FirstNumber}");
}
else
{
    System.Console.Write($"Число {SecondNumber} равно числу {FirstNumber}");
}


