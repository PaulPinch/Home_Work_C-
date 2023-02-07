/*
Семинар 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не в диапазоне от 1");
        }
    }
    return result;
}

string Natural(int i)
{
    if (i > 1) return $"{i}, " + Natural(i - 1);
    else if (i == 1) return $"{i}";
    else return string.Empty;
}

int b = GetNumber("Введите число: ");
Console.WriteLine(Natural(b));