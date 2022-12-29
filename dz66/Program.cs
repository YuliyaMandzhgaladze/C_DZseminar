﻿// Задача 66: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(m, n));

int PrintNumber(int m, int n)
{
    if (m == n) return m;
    return (m + PrintNumber(m + 1, n));
}
