Console.Clear();
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Add number M");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add number N");
int number2 = int.Parse(Console.ReadLine()!);

int ReSumm(int number, int number2)
		{
			int GoStart = number;
			int Finish = number2;
			if(number > number2)
			{
				GoStart = number2;
				Finish = number;
			}
			return (Finish + GoStart)*(Finish - GoStart + 1)/2;
	}
Console.WriteLine(ReSumm(number,number2));