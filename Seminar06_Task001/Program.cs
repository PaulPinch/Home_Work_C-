/*
Семинар 6. Одномерные массивы. Продолжение
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int [] GetArray(string message)
{
    int [] result = new int [100000];
    while(true)
	{
        Console.WriteLine(message);
		string input = Console.ReadLine() ?? "0";
        string [] array = input.Split(", ");
        int count = 0;
        Array.Resize(ref result, array.Length);
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
        if (count == array.Length) break;
        
	}
	return result;
}

int [] myarray = GetArray("Введите целые положительные и отрицательные числа (разделитель: ', '): ");
int count = 0;
for (int i = 0; i < myarray.Length; i++)
{
    if (myarray[i] > 0) count++;
}
Console.WriteLine($"Вы ввели положительных чисел: {count}");