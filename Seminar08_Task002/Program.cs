/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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


int rows = GetNumber("Введите число строк от 2 до 9: ");
int columns = GetNumber("Введите число столбцов от 2 до 9: ");
check:
if (rows < 2)
{
    Console.WriteLine("Число строк должно быть больше 1!");
    rows = GetNumber("Введите число строк от 2 до 9: ");
    goto check;
}
else if (columns < 2)
{
    Console.WriteLine("Число столбцов должно быть больше 1!");
    columns = GetNumber("Введите число столбцов от 2 до 9: ");
    goto check;
}
else if (rows < columns)
{
    Console.WriteLine("Число строк должно быть больше, либо равно числу столбцов!");
    columns = GetNumber("Введите число столбцов от 2 до 9: ");
    goto check;
}
int maxvalue = GetNumber("Введите максимальное значение элемента масива от 1 до 9: ");
int minsumrow = 0;
int min = 0;
int sum = 0;
int [,] anyarray = RandomArray(rows, columns, maxvalue);
int [] sumrows = new int [rows];
Console.WriteLine("Исходный массив:");
PrintArray(anyarray, rows, columns);
for (int i = 0; i < rows; i++)
{
    sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += anyarray[i, j];
    }
    sumrows[i] = sum;
}
for (int i = 0; i < sumrows.Length; i++)
{
    if (i == 0)
    {
        if (sumrows[i] < sumrows[i + 1])
        {
            min = sumrows[i];
            minsumrow = i;
        }
        else
        {
            min = sumrows[i + 1];
            minsumrow = i + 1;
        }
    }
    else if (sumrows[i] < min)
    {
            min = sumrows[i];
            minsumrow = i;
    }
        
}
Console.WriteLine($"Строка с наименьшей суммой: {minsumrow + 1}");