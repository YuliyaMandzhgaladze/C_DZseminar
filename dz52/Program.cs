// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}
void PrintArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [, ] arrayDone = new int [3, 4];
FillArray(arrayDone);

PrintArray(arrayDone);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");

for (int j = 0; j < arrayDone.GetLength(1); j++)
{
    double sum = 0;
    double sredneeArifm = 0;
   
    for (int i = 0; i < arrayDone.GetLength(0); i++)
    {
        sum += arrayDone[i, j];
        sredneeArifm = sum / arrayDone.GetLength(0);
        sredneeArifm = Math.Round(sredneeArifm, 2);
    }
    
     Console.Write($"{ sredneeArifm} ");
}



