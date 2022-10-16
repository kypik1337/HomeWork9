Console.Clear();
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("Add number M");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add number N");
int number2 = int.Parse(Console.ReadLine()!);


int FunkAkkerson (int number, int number2)
    {
    if (number == 0)
    {
    return number2 + 1;
    }
        else
            if ((number != 0) && (number2 == 0))
            {
                return FunkAkkerson(number - 1, 1);
            }
                    else
                        return FunkAkkerson(number - 1, FunkAkkerson(number, number2 - 1));
    }
Console.WriteLine($"A({number},{number2}):= {FunkAkkerson(number,number2)}");