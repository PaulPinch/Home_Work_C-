/*
Семинар 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Random rnd = new Random();
int arraysize = rnd.Next(4, 8);
int [] myarray = new int [arraysize];
int evennumber = 0;
Console.WriteLine("Получен следующий массив:");
for (int i = 0; i < arraysize; i++)
{
    myarray[i] = rnd.Next(100, 999);
    if (myarray[i] % 2 == 0) evennumber++;
    Console.Write(myarray[i]);
    if (i != arraysize - 1) Console.Write(", ");
}
Console.WriteLine();
Console.WriteLine($"Из {arraysize} трехзначных чисел в массиве {evennumber} - четные");