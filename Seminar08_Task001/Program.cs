/*
Семинар 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] RandomArray(int rows, int columns, int maxvalue)
{
    Random rnd = new Random();
    int [,] myarray = new int [rows, columns];
    for (int m = 0; m < rows; m++)
    {
        for (int n = 0; n < columns; n++)
        {
            myarray[m, n] = rnd.Next(0, maxvalue + 1);
        }
    }
    return myarray;
}

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не в диапазоне от 1 до 9");
        }
    }
    return result;
}

void PrintArray (int [,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j]);
            if (j != columns - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}


int rows = GetNumber("Введите число строк от 1 до 9: ");
int columns = GetNumber("Введите число столбцов от 1 до 9: ");
int maxvalue = GetNumber("Введите максимальное значение элемента масива от 1 до 9: ");
int swap = 0;
int [,] unsortedarray = RandomArray(rows, columns, maxvalue);
Console.WriteLine("Исходный массив:");
PrintArray(unsortedarray, rows, columns);
int [,] sortedarray = unsortedarray;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns - 1; k++)
        {
            if (sortedarray[i, k] < sortedarray[i, k + 1])
            {
                swap = sortedarray[i, k];
                sortedarray[i, k] = sortedarray[i, k + 1];
                sortedarray[i, k + 1] = swap;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Сортированный по убыванию по строкам массив:");
PrintArray(sortedarray, rows, columns);