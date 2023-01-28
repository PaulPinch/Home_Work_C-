/*
Семинар 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Random rnd = new Random();
double [,] myarray = new double [3, 4];
Console.WriteLine("Получен следующий массив:");
for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 4; n++)
    {
        double leftint = Convert.ToDouble(rnd.Next(-99 , 99));
        double rightint = Convert.ToDouble(rnd.Next(0 , 99));
        double deci = Math.Round(leftint + rightint / 100, 2);
        myarray[m, n] = deci;
        Console.Write(myarray[m, n]);
        if (n != 3) Console.Write(" ");
    }
    Console.WriteLine();
}