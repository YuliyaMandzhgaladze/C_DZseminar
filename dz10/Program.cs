﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A / 10 % 10;
Console.Write("Вторая цифра числа: ");
Console.WriteLine(B);
