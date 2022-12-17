// 4. Выяснить является ли число чётным

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}