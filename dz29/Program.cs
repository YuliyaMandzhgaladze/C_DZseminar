// Задача 29: Напишите программу, которая 
// задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.
//
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//
// 6, 1, 33 -> [6, 1, 33]



void NArray(int[] masN)
{
    
    int length = masN.Length;
    int i = 0;
    while (i < length)
    {
        masN[i] = new Random().Next(-10, 10);
        i++;
    }
}

void PArray(int[] masP)
{
    int count = masP.Length;
    int i1 = 0;
    while (i1 < count)
    {
        Console.WriteLine(masP[i1]);
        i1++;
    }
}

int[] array = new int[8];

NArray(array);
PArray(array);