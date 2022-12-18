
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number3 = GetNumber(Console.ReadLine() ?? "");

int GetNumber(string message) // Проверка, является ли числом
{
    int result = 0;
    if (int.TryParse(message, out result))
    {
        return result;
    }
    else
    {
        System.Console.WriteLine("Не является числом");
        Console.WriteLine("Введите трехзначное число");
        while (true)
        {   
           // System.Console.WriteLine(message);
            if(int.TryParse(Console.ReadLine(), out result)) 
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Не является числом");
                Console.WriteLine("Введите трехзначное число");
            }
        }
        return result;
    }
    
}
while(true) // Проверка, является ли трехзначным числом
{
    if (number3 > -99 && number3 < 99)
    {
        System.Console.WriteLine("Слишком мало знаков");
        Console.WriteLine("Введите трехзначное число");
        number3 = GetNumber(Console.ReadLine() ?? "");
    }
    else if (number3 < -999 || number3 > 999)
    {
        System.Console.WriteLine("Слишком много знаков");
        Console.WriteLine("Введите трехзначное число");
        number3 = GetNumber(Console.ReadLine() ?? "");
    }
    else
    {
        break;
    }
}

int number2 = number3 / 10;
int number1 = number3 / 100;

int secondDigit = number2 - number1 * 10;

System.Console.WriteLine($"Вторая цифра введеного числа: {Math.Abs(secondDigit)}");
