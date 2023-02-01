/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double [] GetCoefficients(string message)
{
    double [] result = new double [4];
    while(true)
	{
        Console.Write(message);
		string input = Console.ReadLine() ?? "0";
        string [] array = input.Split(", ");
        int count = 0;
        if (array.Length == 4)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(double.TryParse(array[i], out double res))
                {
                    result[i] = res;
                    count++;
                }
                else
                {
                    Console.WriteLine("Аргументы введены некорректно!");
                    Console.WriteLine("Введите аргументы через разделитель (, )");
                }
            }
            if (count == 4) break;
        }
        else
        {
            Console.WriteLine("Аргументы введены некорректно!");
            Console.WriteLine("Введите аргументы через разделитель (, )");
        }
        
	}
	return result;
}

double [] coeffs = GetCoefficients("Введите аргументы функции (b1, k1, b2, k2): ");
double b1 = coeffs[0];
double k1 = coeffs[1];
double b2 = coeffs[2];
double k2 = coeffs[3];
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны!");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают друг с другом!");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = b1 + k1 * x;
    Console.WriteLine($"Прямые пересекутся в точке с координатами ({x}; {y}).");
}