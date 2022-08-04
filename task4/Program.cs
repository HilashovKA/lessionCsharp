//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от - N до N.
Console.Clear();
Console.WriteLine("Введите любое целое число");

int number = Convert.ToInt32(Console.ReadLine());
int count = number;
Console.Write(number);
while(count > -number)
{
    number = number - 1;
    Console.Write(number) ;
}