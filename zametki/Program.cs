// преобразование числа в строку

//int number = int.Parse(Console.ReadLine()!);
//string numStr = $"{number}";
//int ln = numStr.Length;

//int N = int.Parse(Console.ReadLine()!);
//string str = $"{N}";

// пример поиска третьей цифры:

Console.Write("Введите число: ");
string num = Console.ReadLine();
if (num.Length > 2)
{
    Console.WriteLine("Третья цифра: " + num[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
