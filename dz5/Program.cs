// 5. Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A % 10;
Console.Write("Последняя цифра числа: ");
Console.WriteLine(B);
