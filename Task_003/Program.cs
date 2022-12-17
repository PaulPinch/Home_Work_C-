
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число: ");
string stringA = Console.ReadLine() ?? "0";

int numberA = int.Parse(stringA);
bool evenA = false;

if (numberA % 2 == 0)
{
    evenA = true;
}

Console.WriteLine(evenA);
