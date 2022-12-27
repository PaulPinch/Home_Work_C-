// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

double[] GetPow(int x)
{
    double[] mass = new double[x];
    for (int index = 0; index < x; index++)
    {
        mass[index] = Math.Pow(index+1, 3);
    }
    return mass;    
}

int result = GetNumber("Введите число");
double[] massPow = GetPow(result); 
for (int i = 0; i < massPow.Length; i++)
{
    Console.WriteLine($"Куб числа {i+1} равен {massPow[i]}");
}


