// * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное 
//значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2
// * по желанию


// работает не корректно по причине ошибки в поиске минимумов по столбцам. Не смог найти ошибку.


int[,] AddMatrix (string msg) // функция заполнения массива 2X3 числами введенными пользователем
{
    int[,] Matrix = new int[2,3]; 
    System.Console.WriteLine(msg);   
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return Matrix;
}

void PrintArray(int[,] Arr) // вывод матрицы для проверки
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            System.Console.Write($"{Arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int SumMaxLine(int[,] Arr) // функция для подсчета максимумов в каждой строке
{
int sumMax1 = 0;
int sumMax = 0;
for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            if (sumMax1 < Arr[i,j])
            {
                sumMax1 = Arr[i,j];
            }
            
        }
        sumMax += sumMax1;
        sumMax1 = 0;
    }
    return sumMax;
}

int SumMinColumn(int[,] Arr) // функция для подсчета минимумов в каждом столбце
{
int min = 1000;
int sumMin = 0;
for (int j = 0; j < Arr.GetLength(1); j++)
    {
        for (int i = 0; i < Arr.GetLength(0); i++)
        {
            if (min > Arr[i,j])
            {
                min = Arr[i,j];
            }
        }
        sumMin += min;
        min = 1000;
    }
return sumMin;
}


int[,] Matrix = AddMatrix("Введите значения 2-ух мерной матрицы формата 2х3 >");
PrintArray(Matrix);
int sum1 = SumMaxLine(Matrix);
int sum2 = SumMinColumn(Matrix);
System.Console.WriteLine(sum1); // вывод суммы максимума по строкам
System.Console.WriteLine(sum2); // вывод суммы минимума по столбцам

System.Console.WriteLine($"разница между максимумами строк и минимумами столбцов составляет {sum1 - sum2}");
