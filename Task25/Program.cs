﻿/*
Задача 25: Напишите цикл,
который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число А, основание степени");
int numa = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите число В, в которое возводится основание степени");
int numb = int.Parse(Console.ReadLine() ??"");
Console.WriteLine();
double result = Math.Pow(numa, numb);
Console.WriteLine($"= {result}");