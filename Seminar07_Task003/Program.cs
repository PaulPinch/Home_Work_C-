/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);

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

Random rnd = new Random();
int row = GetNumber("Введите число строк массива: ");
int column = GetNumber("Введите число столбцов массива: ");
int [,] myarray = new int [row, column];
double [] meanarray = new double [column];
Console.WriteLine("Получен следующий массив:");
for (int m = 0; m < row; m++)
{
    for (int n = 0; n < column; n++)
    {
        int number = rnd.Next(0, 9);  // как пример
        myarray[m, n] = number;
        Console.Write(myarray[m, n]);
        if (n != column - 1) Console.Write(" | ");
    }
    Console.WriteLine();
}
for (int i = 0; i < column; i++)
{
    double accum = 0;
    for (int j = 0; j < row; j++)
    {
        accum += Convert.ToDouble(myarray[j, i]);
    }
    meanarray[i] = Math.Round(accum / row, 2);
}
Console.WriteLine("------------");
for (int i = 0; i < column; i++)
{
    Console.Write(meanarray[i]);
    if (i != column - 1) Console.Write(" | ");
}
Console.WriteLine(" - средние значения по столбцам.");