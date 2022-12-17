Console.Write("Введите число дня недели: ");
int D = int.Parse(Console.ReadLine());
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;
if (D == a)
{
    Console.Write("Понедельник");
}
if (D == b)
{
    Console.Write("Вторник");
}
if (D == c)
{
    Console.Write("Среда");
}
if (D == d)
{
    Console.Write("Четверг");
}
if (D == e)
{
    Console.Write("Пятница");
}
if (D == f)
{
    Console.Write("Суббота");
}
if (D == g)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Только число от 1 до 7: ");
}