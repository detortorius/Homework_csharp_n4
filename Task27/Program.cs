/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.WriteLine("Введите положительное число");
int num = int.Parse(Console.ReadLine() ??"");
if (num < 0)
{
    Console.WriteLine("Введено отрицательное число");
    return;
}
int summ = 0;
while (num > 0)
{
    summ = summ + num % 10;
    num = (num - num % 10) / 10;
}
Console.WriteLine($"Сумма цифр в числе составляет {summ}");