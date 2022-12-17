/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.Write("Введите число: ");
string stringA = Console.ReadLine() ?? "0";

int numberA = int.Parse(stringA);

int count = 1;

if (numberA < 0)
{
    System.Console.WriteLine("Число не должно быть отрицательным!");
}
else
{
    while (count < numberA + 1)
    {
        if (count % 2 == 0)
        {
            System.Console.Write($"{count} ");
        }
        count++;
    }
}

