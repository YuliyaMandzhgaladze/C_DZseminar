// 7. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int A = new Random().Next(10, 99);
Console.Write("Введите число от 10 до 99: ");
int A = int.Parse(Console.ReadLine());
int B = A / 10;
int C = A % 10;
if(B > C)
{
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(B);
}
else
{
    Console.Write("Наибольшая цифра числа: ");
    Console.WriteLine(C);
}
