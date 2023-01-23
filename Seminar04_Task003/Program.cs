/*
Домашнее Задание к Семинару 4

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/

int [] GetArray(string message)
{
    int [] result = new int [8];
    while(true)
	{
        Console.WriteLine(message);
		string input = Console.ReadLine() ?? "0";
        string [] array = input.Split(", ");
        int count = 0;
        if (array.Length == 8)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(int.TryParse(array[i], out int res))
                {
                    result[i] = res;
                    count++;
                }
                else
                {
                    Console.Write("Среди элементов массива есть строка (строки). ");
                    Console.WriteLine("Введите массив корректно.");
                }
            }
            if (count == 8) break;
        }
        else
        {
            Console.Write("Массив должен состоять из 8 чисел! ");
            Console.WriteLine("Введите массив корректно.");
        }
        
	}
	return result;
}


int [] show = GetArray("Введите массив, разделяя элементы ', '");
Console.WriteLine("Были введены следующие элементы:");
for (int i = 0; i < 8; i++)
{
    Console.WriteLine(show[i]);
}