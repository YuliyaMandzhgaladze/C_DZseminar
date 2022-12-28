// Задача 50. Напишите программу, которая на вход принимает число,
//  и возвращает индексы числа в двумерном массиве или же указание, 
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


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
//Console.WriteLine();
PrintArray(arrayDone);

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int m = -1;
int n = -1;


for (int i = 0; i < arrayDone.GetLength(0); i++)
{
    for (int j = 0; j < arrayDone.GetLength(1); j++)
    {
        if (number == arrayDone[i, j])
        {
            Console.WriteLine("Индексы числа: "+i+", "+j);
            
            m = i;
            n = j;
            Console.WriteLine("Индексы числа: "+m+", "+n);

        }

    }
}
if (m == -1 && n == -1)
{
    Console.Write("Такого элемента нет в массиве!");
    // return;
}
  





   
