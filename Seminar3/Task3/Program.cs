// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = Promt("Введите число >");
System.Console.WriteLine("");
int count = 1;
while (count <= num)
{
    System.Console.Write($"{count*count*count} ");
    count = count +1;
}
