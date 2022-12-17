// 9. Выяснить, кратно ли число заданному, если нет, вывести остаток

int A = 24;
Console.Write("Введите число: ");
int B = int.Parse(Console.ReadLine());
if(A % B == 0)
{
    Console.Write("Число кратно заданному");
}
else
{
    Console.WriteLine("Число НЕ кратно заданному");
    Console.Write("Остаток: ");
    Console.WriteLine(A % B);
}