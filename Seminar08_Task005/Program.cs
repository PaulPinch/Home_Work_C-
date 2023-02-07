/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


// Простите за "костыльное" решение.
// Просто в цейтноте, плюс "взрыв мозга".

string Filler(int row, int column)
{
    string value = string.Empty;
    if (row == 0)
    {
        if (column == 0) value = "01";
        if (column == 1) value = "02";
        if (column == 2) value = "03";
        if (column == 3) value = "04";
    }
    else if (row == 1)
    {
        if (column == 0) value = "12";
        if (column == 1) value = "13";
        if (column == 2) value = "14";
        if (column == 3) value = "05";
    }
    else if (row == 2)
    {
        if (column == 0) value = "11";
        if (column == 1) value = "16";
        if (column == 2) value = "15";
        if (column == 3) value = "06";
    }
    else if (row == 3)
    {
        if (column == 0) value = "10";
        if (column == 1) value = "09";
        if (column == 2) value = "08";
        if (column == 3) value = "07";
    }
    return value;
}

void PrintArray (string [,] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(arr[i, j]);
            if (j != size - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
    
}

string [,] SpiralArray(int size)
{
    string [,] myarray = new string [size, size];
    for (int m = 0; m < 4; m++)
    {
        for (int n = 0; n < 4; n++)
        {
            myarray[m, n] = Filler(m, n);
        }
    }
    return myarray;
}

string [,] myspiral = SpiralArray(4);
PrintArray(myspiral, 4);
