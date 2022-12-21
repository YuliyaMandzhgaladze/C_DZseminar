// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
//
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16


Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
int A1 = A;
int i = 1;
while (i < B)
{
    A1 = A1*A;
    i++;
}
Console.WriteLine(A1);