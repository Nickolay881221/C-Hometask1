//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int Promt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int Number = Promt("Введите число >");
int Count = 2;
while (Count <= Number)
{
    System.Console.Write($"{Count} ");
    Count = Count + 2;
}