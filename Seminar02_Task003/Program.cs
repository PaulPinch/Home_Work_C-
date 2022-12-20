
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

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

Console.WriteLine("Введите число дня недели:");
int wdNumber = GetNumber(Console.ReadLine() ?? "");

while(true) // Проверка, является ли числом дня недели
{
    if (wdNumber < 1 || wdNumber > 7)
    {
        System.Console.WriteLine("Не является числом дня недели.");
        Console.WriteLine("Введите число дня недели.");
        wdNumber = GetNumber(Console.ReadLine() ?? "");
    }
    else
    {
        break;
    }
}

string result = "";

switch (wdNumber)
{
    case 6:
        result = "Это суббота.";
        break;
    case 7:
        result = "Это воскресенье.";
        break;
    default:
        result = "Это обычный день недели.";
        break;
}

System.Console.WriteLine(result);
