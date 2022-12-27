// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}
void PrintArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [, ] matrix = new int [3, 4];
FillArray(matrix);

PrintArray(matrix);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    double sredneeArifm = 0;
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
        sredneeArifm = sum / matrix.GetLength(0);
        sredneeArifm = Math.Round(sredneeArifm, 2);
    }
    
     Console.Write($"{ sredneeArifm} ");
}



