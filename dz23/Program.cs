// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
double N = double.Parse(Console.ReadLine());


for (double a = 1; a <= N; a++)
{
    double N1 = Math.Pow(a, 3); 
    Console.WriteLine(N1);
}
