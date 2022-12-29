// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

void FillArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
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


int [, ] array = new int [4, 4];


FillArray(array);
PrintArray(array);

int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;

for(int i=0; i == 0; i++)
{
  
  for(int j=0; j<array.GetLength(1); j++) 
  {
   sum1 += array[i,j];
  }
  Console.Write("Сумма первой строки: ");
  Console.WriteLine(sum1);

}
for(int i=1; i == 1; i++)
{
  
  for(int j=0; j<array.GetLength(1); j++) 
  {
   sum2 += array[i,j];
  }
  Console.Write("Сумма второй строки: ");
  Console.WriteLine(sum2);

}
for(int i=2; i == 2; i++)
{
  
  for(int j=0; j<array.GetLength(1); j++) 
  {
   sum3 += array[i,j];
  }
  Console.Write("Сумма третьей строки: ");
  Console.WriteLine(sum3);

}
for(int i=3; i == 3; i++)
{
  
  for(int j=0; j<array.GetLength(1); j++) 
  {
   sum4 += array[i,j];
  }
  Console.Write("Сумма четвертой строки: ");
  Console.WriteLine(sum4);

}

int Min(int summa1, int summa2, int summa3, int summa4)
{
    int min = summa1;
    if(summa2<min) min = summa2;
    if(summa3<min) min = summa3;
    if(summa4<min) min = summa4;
    return min;
}

int min = Min(sum1, sum2, sum3, sum4);

Console.WriteLine();
if (min == sum1)
{
    Console.WriteLine("наименьшая сумма элементов в 1 строке: "+min);
}
    if (min == sum2)
{
    Console.WriteLine("наименьшая сумма элементов в 2 строке: "+min);
}
if (min == sum3)
{
    Console.WriteLine("наименьшая сумма элементов в 3 строке: "+min);
}
if (min == sum4)
{
    Console.WriteLine("наименьшая сумма элементов в 4 строке: "+min);
}




