//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int number1 = new Random().Next(99,1000);
System.Console.WriteLine(number1);
System.Console.WriteLine(number1/100*10+number1%10);