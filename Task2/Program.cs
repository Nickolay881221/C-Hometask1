//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Promt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int A = Promt("Введите первое число >");
int B = Promt("Введите второе число >");
int C = Promt("Введите третье число >");
int Count = 0;
int Max = 0;
int [] Numbers = new int[3] {A, B, C};
while (Count < 3)
{
    if (Max < Numbers[Count])
    {
        Max = Numbers[Count];
    }
    Count = Count + 1;
}
System.Console.Write(Max);