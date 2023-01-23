/*
Домашнее Задание к Семинару 4

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3^5)
2, 4 -> 16
*/

int GetNumber(string message)
{
	int result = 0;
	while(true)
	{
		Console.WriteLine(message);
		if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
		{
			break;
		}
		else
		{
			Console.WriteLine("ввели не число или меньше 1.");
		}
	}
	return result;
}

int numberA = GetNumber("Введите число A больше 1: ");
int numberB = GetNumber("Введите число B больше 1: ");
int power = numberA;
for (int i = 1; i < numberB; i++)
{
    power *= numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} = {power}");