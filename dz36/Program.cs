// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int [5];
int sum = 0;

Console.Write("[");
for (int i = 0; i <array.Length; i++)
{
    int randomNumber = new Random().Next(-10, 10);
    array [i] = randomNumber;
    Console.Write(array [i].ToString() + ", ");
    
}
Console.WriteLine("]");


for (int i = 0; i < array.Length; i++)
{
    if(i%2 != 0)
    {
        sum = sum + array[i];
    }   
}
Console.Write("Сумма элементов на нечетных позициях: "+sum);
