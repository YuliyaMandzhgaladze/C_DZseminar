// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void FillArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
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

int [, ] array1 = new int [2, 2];
int [, ] array2 = new int [2, 2];
int [, ] array3 = new int [2, 2];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();


for (int i1=0; i1<array1.GetLength(0); i1++)
{
    for (int j1=0; j1<array1.GetLength(1); j1++)
    {
            for (int i2=0; i2<array2.GetLength(0); i2++)
            {
                for (int j2=0; j2<array2.GetLength(1); j2++)
                {
                    for (int i3=0; i3<array3.GetLength(0); i3++)
                    {
                        for (int j3=0; j3<array3.GetLength(1); j3++)
                        {
                            if(i1 == i2 && j1 == j2 && i1 == i3 && j1 == j3)
                            {
                                array3[i3, j3] = array1[i1, j1] * array2[i2, j2];
                            }
                        }
        
                    }
                }
        
            }
    }
        
}


PrintArray(array3);
Console.WriteLine();