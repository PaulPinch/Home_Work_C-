/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
int Ackermann(int m, int n)
{
    int result = 0;
    if (m > 0 && n > 0) result = Ackermann(m - 1, Ackermann(m, n - 1));
    else if (m > 0 && n == 0) result = Ackermann(m - 1, 1);
    else if (m == 0) return n + 1;
    return result;

}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
Console.WriteLine($"A({m},{n}) = {Ackermann(m, n)}");