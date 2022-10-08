// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите число");

if (number / 100 == 0)
{
    System.Console.WriteLine("Третья цифра отсутствует");
}
else
{
    System.Console.WriteLine(number / 100 % 10);
}