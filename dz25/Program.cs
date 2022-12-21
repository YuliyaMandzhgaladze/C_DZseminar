// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
//
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16


Console.Write("Введите первое число: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int S = int.Parse(Console.ReadLine());
int N1 = N;
int i = 1;
while (i < S)
{
    N1 = N1*N;
    i++;
}
Console.WriteLine(N1);