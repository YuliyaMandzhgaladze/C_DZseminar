// 8. Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A / 100;
int C = A % 10;
Console.Write(B);
Console.Write(C);

