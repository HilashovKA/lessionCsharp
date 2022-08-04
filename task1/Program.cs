// Напишите программу, которая на вход принимает число и выдаёт его квадрат.

Console.Clear();
System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
System.Console.Write("Квадрат числа равен ");
Console.WriteLine(result);