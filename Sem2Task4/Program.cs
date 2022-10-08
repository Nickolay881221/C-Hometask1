//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Promt("Введите номер дня недели от 1 до 7");

if (number > 7 || number < 1) {System.Console.WriteLine("Введено некорректное число");}
else if (number == 6 || number == 7) {System.Console.WriteLine("Введенный день является выходным");}
else{System.Console.WriteLine("Введенный день является рабочим днём");}