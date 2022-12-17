// 6. Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A / 10 % 10;
Console.Write("Вторая цифра числа: ");
Console.WriteLine(B);
