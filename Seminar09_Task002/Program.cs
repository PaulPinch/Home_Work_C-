/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
int NaturalSum(int m, int n)
{
    int result = 0;
    if (m == n) return n;
    else if (m < n)
    {
        result = m + NaturalSum(m + 1, n );
    }
    return result;
}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {NaturalSum(m, n)}");