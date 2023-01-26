/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Random rnd = new Random();
int arraysize = rnd.Next(4, 8);
double [] myarray = new double [arraysize];
int right = 0;
int left = 0;
double leftdouble = 0;
double rightdouble = 0;
double deci = 0;
double minvalue = 0;
double maxvalue = 0;
Console.WriteLine("Получен следующий массив:");
for (int i = 0; i < arraysize; i++)
{
    left = rnd.Next(0 , 100);
    leftdouble = Convert.ToDouble(left);
    right = rnd.Next(1 , 99);
    rightdouble = Convert.ToDouble(right);
    deci = leftdouble + rightdouble / 100;
    myarray[i] = deci;
    if (minvalue == 0 && maxvalue == 0)
    {
        minvalue = myarray[i];
        maxvalue = myarray[i];
    }
    else
    {
        if (myarray[i] < minvalue)
        {
            minvalue = myarray[i];
        }
        else if (myarray[i] > maxvalue)
        {
            maxvalue = myarray[i];
        }
    }
    Console.Write(myarray[i]);
    if (i != arraysize - 1) Console.Write(" ");
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({maxvalue}) и минимальным ({minvalue}) элементами массива равна {maxvalue - minvalue}");