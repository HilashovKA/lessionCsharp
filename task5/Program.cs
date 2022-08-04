//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 10;
Console.WriteLine($"Последняя цифра {number} равна {digit}");