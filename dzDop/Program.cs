// Доп.Задача Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21



int[] array = { 2, 20, 3, 5, 8 }; 
Console.Write("Заданный массив: ");
Console.Write("[");
for (int i = 0; i <array.Length; i++)
{
    int Number = array[i];
    Console.Write(array [i].ToString() + ", ");
    
}
Console.WriteLine("]");

int proizv1 = array[0]*array[4];
int proizv2 = array[1]*array[3];
Console.WriteLine("Произведение первой пары элементов: "+proizv1);
Console.WriteLine("Произведение второй пары элементов: "+proizv2);
Console.Write("Новый массив из произведений пары элементов: ");


int[] arrayNew = {proizv1, proizv2};

Console.Write("[");
for (int i = 0; i <arrayNew.Length; i++)
{
    int Number = arrayNew[i];
    Console.Write(arrayNew [i].ToString() + ", ");
    
}
Console.WriteLine("]");


