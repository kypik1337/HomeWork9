
Console.Clear();
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine("Введите число N");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine(RecursNumber(Number));
string RecursNumber(int Number)
    {   
        if ( Number == 1)
            {
                return Number.ToString();
            }
        return (Number + ", " + RecursNumber(Number -1));
    }