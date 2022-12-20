
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
double LongNumber = GetNumber(Console.ReadLine() ?? "");
double GetNumber(string message) // Проверка, является ли числом
{
    int result = 0;
    if (int.TryParse(message, out result))
    {
        return result;
    }
    else
    {
        System.Console.WriteLine("Не является числом");
        Console.WriteLine("Введите число");
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
                Console.WriteLine("Введите число");
            }
        }
        return result;
    }
    
}

if (LongNumber > -100 && LongNumber < 100)
{
    System.Console.WriteLine($"Число {LongNumber} не имеет третьего знака");
}
else
{
    double StopWatch = Math.Abs(LongNumber);
    while (Math.Floor(StopWatch) > 0)
    {
        StopWatch = StopWatch / 10;
    }
    double Number3 = Math.Floor(StopWatch * 1000);
    double Hundreds = Math.Floor(Number3 / 100) * 100;
    double Tens = Math.Floor((Number3 - Hundreds) / 10) * 10;
    double Digit3 = Number3 - (Hundreds + Tens);
    System.Console.WriteLine($"В числе {LongNumber} третий знак равен {Digit3}");
}
