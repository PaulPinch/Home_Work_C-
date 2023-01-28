/*
Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// Вариант 1: Поиск числа по адресу

int [] GetArray(string message)
{
    int [] result = new int [2];
    while(true)
	{
        Console.Write(message);
		string input = Console.ReadLine() ?? "0";
        string [] array = input.Split(", ");
        int count = 0;
        if (array.Length == 2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(int.TryParse(array[i], out int res))
                {
                    result[i] = res;
                    count++;
                }
                else
                {
                    Console.WriteLine("Введите адрес корректно.");
                }
            }
            if (count == 2) break;
        }
        else
        {
            Console.Write("Введите номер строки и номер столбца, разделяя их ', ': ");
            Console.WriteLine("Введите адрес корректно.");
        }
        
	}
	return result;
}

Random rnd = new Random();
int rows = rnd.Next(3, 8);
int columns = rnd.Next(3, 8);
int [,] myarray = new int [rows, columns];
Console.WriteLine("Получен следующий массив:");
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        int number = rnd.Next(0, 9);
        myarray[m, n] = number;
        Console.Write(myarray[m, n]);
        if (n != columns - 1) Console.Write(" | ");
    }
    Console.WriteLine();
}
int [] address = GetArray("Введите номер строки и номер столбца, разделяя их ', ': ");
if (address[0] > rows || address[1] > columns)
{
    Console.WriteLine("Такого адреса в массиве нет!");
}
else
{
    Console.WriteLine($"В массииве по адресу {address[0]}, {address[1]} находится число {myarray[address[0] - 1, address[1] - 1]}");
}

// Вариант 2: Определение адреса (-ов) по числу

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 9 && result < 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не в диапазоне от 10 до 99");
        }
    }
    return result;
}


Random rnd = new Random();
int rows = rnd.Next(3, 8);
int columns = rnd.Next(3, 8);
int [,] myarray = new int [rows, columns];
Console.WriteLine("Получен следующий массив:");
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        int number = rnd.Next(10, 99);
        myarray[m, n] = number;
        Console.Write(myarray[m, n]);
        if (n != columns - 1) Console.Write(" | ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int searchnumber = GetNumber("Введите число от 10 до 99: "); // Для красоты отображения
bool found = false;
int foundrow = 0;
int foundcolumn = 0;
int count = 0;
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        if (searchnumber ==  myarray[m, n])
        {
            foundrow = m;
            foundcolumn = n;
            found = true;
            count++;
            Console.WriteLine($"Число {searchnumber} находится по адресу: {foundrow + 1}, {foundcolumn + 1}");
        }
        if (m == rows - 1 && n == columns - 1 && count > 0)
        {
            found = true;
        }
        else
        {
            found = false;
        }
    }
}
if (found == false) Console.WriteLine($"Числа {searchnumber} в данном массиве нет!");
