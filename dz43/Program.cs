// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void CrossPoint(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
// double y = (k2*b1-k1*b2)/(k2-k1);
double y = k1*x+b1;
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.Write("Введите первую координату первой прямой: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите вторую координату первой прямой: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите первую координату второй прямой: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите вторую координату второй прямой: ");
double k2 = double.Parse(Console.ReadLine());

CrossPoint(k1,b1,k2,b2);


