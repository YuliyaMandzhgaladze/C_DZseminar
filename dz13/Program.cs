// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

if(A < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(A > 99 && A < 1000)
{
    int B = A % 10;
    Console.Write("Третья цифра: ");
    Console.WriteLine(B);
}
if(A > 999 && A < 10000)
{
    int C = A % 100;
    int D = C / 10;
    Console.Write("Третья цифра: ");
    Console.WriteLine(D);
}
if(A > 9999 && A < 100000)
{
    int E = A % 1000;
    int F = E / 100;
    Console.Write("Третья цифра: ");
    Console.WriteLine(F);
}


