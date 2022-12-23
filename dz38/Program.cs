// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double Max(double a1, double a2, double a3, double a4, double a5)
{
    double max = a1;
    if(a2>max) max = a2;
    if(a3>max) max = a3;
    if(a4>max) max = a5;
    if(a5>max) max = a5;
    return max;
}

double Min(double a1, double a2, double a3, double a4, double a5)
{
    double min = a1;
    if(a2<min) min = a2;
    if(a3<min) min = a3;
    if(a4<min) min = a5;
    if(a5<min) min = a5;
    return min;
}


double[] array = { 1, 2, 3, 4, 8 }; 


double max = Max(array[0], array[1], array[2], array[3], array[4]);
double min = Min(array[0], array[1], array[2], array[3], array[4]);
double raznost = max - min;
Console.WriteLine("Максимальный элемент: "+max);
Console.WriteLine("Минимальный элемент: "+min);
Console.WriteLine("Разность между максимальным и минимальным элементом: "+raznost);
