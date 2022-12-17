/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите число А: ");
string stringA = Console.ReadLine() ?? "0";
Console.Write("Введите число B: ");
string stringB = Console.ReadLine() ?? "0";

int numberA = int.Parse(stringA);
int numberB = int.Parse(stringB);

int max = 0;
int min = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.WriteLine($"Max = {max}, Min = {min}");
