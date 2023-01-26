/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Random rnd = new Random();
int arraysize = rnd.Next(4, 8);
int [] myarray = new int [arraysize];
int oddnumbersum = 0;
Console.WriteLine("Получен следующий массив:");
for (int i = 0; i < arraysize; i++)
{
    myarray[i] = rnd.Next(-100 , 100); // намеренно ограничена для простоты проверки
    if (i % 2 != 0) oddnumbersum += myarray[i];
    Console.Write(myarray[i]);
    if (i != arraysize - 1) Console.Write(", ");
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел в массиве, стоящих на нечетных позициях равна {oddnumbersum}");