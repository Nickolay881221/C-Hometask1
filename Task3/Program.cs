//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int Promt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int Number = Promt("Введите число >");
if (Number%2==0)
{
    System.Console.Write("Число четное");
}
else
{
    System.Console.Write("число нечетное");
}