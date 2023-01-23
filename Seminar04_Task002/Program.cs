/*
Домашнее Задание к Семинару 4

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
decimal GetNumber(string message)
{
	int result = 0;
	while(true)
	{
		Console.WriteLine(message);
		if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
		{
			break;
		}
		else
		{
			Console.WriteLine("ввели не число или меньше 1.");
		}
	}
    decimal output = Convert.ToDecimal(result);
	return output;
}

decimal GetDigitSum (decimal number)
{
	decimal left = number;
    decimal right = 0;
    decimal deci = 0;
 //   decimal digitvalue = 0;
    decimal digitsum = 0;
    while (left > 0)
    {
        deci = left / 10;
        right = deci - Math.Floor(deci);
        digitsum += right * 10;
        left = Math.Floor(deci);
    }
    return digitsum;

}

decimal newnumber = GetNumber("Введите целое число больше нуля.");
decimal newsum = GetDigitSum (newnumber);
int final = Convert.ToInt32(newsum);
Console.WriteLine($"Сумма цифр числа {newnumber} равна {final}");