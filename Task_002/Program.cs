/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите число А: ");
string stringA = Console.ReadLine() ?? "0";
Console.Write("Введите число B: ");
string stringB = Console.ReadLine() ?? "0";
Console.Write("Введите число C: ");
string stringC = Console.ReadLine() ?? "0";

int numberA = int.Parse(stringA);
int numberB = int.Parse(stringB);
int numberC = int.Parse(stringC);

int first_max = 0;
int result = 0;

if (numberA > numberB)
{
    first_max = numberA;
}
else
{
    first_max = numberB;
}

if (first_max > numberC)
{
    result = first_max;
}
else
{
    result = numberC;
}

Console.WriteLine($"Максимальное число: {result}");
