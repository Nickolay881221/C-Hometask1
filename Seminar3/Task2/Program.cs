// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] Promt(string message) // функция записи в переменную введенного целого числа
{
    System.Console.WriteLine(message);
    int[] result = new int[3] {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
    return result;
}

int[] num1 = Promt("Введите координаты первой точки, через enter");
int[] num2 = Promt("Введите координаты второй точки, через enter");
// int count = 0;
//     while (count < num1.Length)
//     {
//         System.Console.WriteLine(num1[count]);
//         count = count + 1;
//     }
double len = Math.Sqrt((num2[2]-num1[2])*(num2[2]-num1[2])+(num2[1]-num1[1])*(num2[1]-num1[1])+(num2[0]-num1[0])*(num2[0]-num1[0]));
System.Console.WriteLine(len);