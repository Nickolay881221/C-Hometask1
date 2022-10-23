// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Promt(string message) // функция записи в переменную введенного целого числа
{
    System.Console.WriteLine(message);
    double result = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
    return result;
}

double[] PtintPointCross(double k1, double b1, double k2, double b2) // метод поиска точек пересечения с зачислением значения в массив в формате [x, y]
{   
    double[] Arr = new double[2];
    Arr[0] = Math.Round((b2-b1)/(k1-k2), 1);
    Arr[1] = Math.Round((Arr[0] - b1)/k1, 1);
    return Arr;
}

double b1 = Promt("Введите значение b1>");
double k1 = Promt("Введите значение K1>");
double b2 = Promt("Введите значение b2>");
double k2 = Promt("Введите значение k2>");

double[] Arr = PtintPointCross(k1, b1, k2, b2);

System.Console.WriteLine($"координаты точки пересечения ({Arr[0]},{Arr[1]})");

