/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,] RandomMatrix(int size)
{
    Random rnd = new Random();
    int [,] myarray = new int [size, size];
    for (int m = 0; m < size; m++)
    {
        for (int n = 0; n < size; n++)
        {
            myarray[m, n] = rnd.Next(1, 10);
        }
    }
    return myarray;
}

void PrintMatrix (int [,] arr1, int [,] arr2)
{   
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (j < 2)
            {
                Console.Write(arr1[i, j]);
            }
            else Console.Write(arr2[i, j - 2]);
            if (j == 1)
            {
                Console.Write(" | ");
            }
            else if (j < 4) Console.Write(" ");
        }
        Console.WriteLine();
    }
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

int [,] matA = RandomMatrix(2);
int [,] matB = RandomMatrix(2);
Console.WriteLine("Исходные матрицы:");
PrintMatrix(matA, matB);
int [,] ProductM= new int [2, 2];
ProductM[0, 0] = matA[0, 0] * matB[0, 0] + matA[0, 1] * matB[1, 0];
ProductM[0, 1] = matA[0, 0] * matB[0, 1] + matA[0, 1] * matB[1, 1];
ProductM[1, 0] = matA[1, 0] * matB[0, 0] + matA[1, 1] * matB[1, 0];
ProductM[1, 1] = matA[1, 0] * matB[0, 1] + matA[1, 1] * matB[1, 1];
Console.WriteLine("Результат умножения Матрицы А на Матрицу В:");
PrintArray(ProductM, 2, 2);