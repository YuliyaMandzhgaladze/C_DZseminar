// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
//
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите первую координату первой точки: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите вторую координату первой точки: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите третью координату первой точки: ");
double z = double.Parse(Console.ReadLine());
Console.Write("Введите первую координату второй точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите вторую координату второй точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите третью координату второй точки: ");
double z1 = double.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(x1-x, 2)+Math.Pow(y1-y, 2)+Math.Pow(z1-z, 2));
Console.WriteLine("Расстояние между точками "+ ab);
