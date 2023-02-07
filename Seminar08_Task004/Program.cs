/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] RandomArray(int dimesion)
{
    Random rnd = new Random();
    int rows = dimesion;
    int columns = dimesion;
    int tier = dimesion;
    int [,,] myarray = new int [rows, columns, tier];
    int [] usedvalues = new int[dimesion * dimesion * dimesion]; // Некрасиво, но проще чем переливать из int в double и обратно
    int count = 0;
    int newvalue = 0;
    for (int i = 0; i < tier; i++)
    {
        for (int m = 0; m < rows; m++)
        {
            for (int n = 0; n < columns; n++)
            {
                GenerateNew:
                newvalue = rnd.Next(10, 100);
                if (IsValue(usedvalues, newvalue) == false)
                {
                    myarray[i, m, n] = newvalue;
                    usedvalues[count] = newvalue;
                    count++;
                }
                else goto GenerateNew;
            }
        }
    }
    return myarray;
}

bool IsValue(int [] array, int target)
{
    bool status = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            status = true;
            break;
        }
    }
    return status;
}

void PrintArray (int [,,] arr, int dimesion)
{
    int rows = dimesion;
    int columns = dimesion;
    int tier = dimesion;
    for (int k = 0; k < tier; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{arr[k, i, j]}({k},{i},{j})");
                if (j != columns - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] newarray = RandomArray(4); // Массив 4х4х4 выбран для иллюстративности, т.к. 2х2х2 давал уникальные значения и без валидации в 95% случаев
PrintArray(newarray, 4);