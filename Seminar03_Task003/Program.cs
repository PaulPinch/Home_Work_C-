/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

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

double[] GetPow(int x)
{
    double[] mass = new double[x];
    for (int index = 0; index < x; index++)
    {
        mass[index] = Math.Pow(index+1, 3);
    }
    return mass;    
}

int result = GetNumber("Введите число");
double[] massPow = GetPow(result); 
for (int i = 0; i < massPow.Length; i++)
{
    Console.WriteLine($"Куб числа {i+1} равен {massPow[i]}");
}

/*
Решение задачи на VBA для Excel:
Sub Sem3Task23()
 'Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Dim Asker As String, Result As String, ending As String
    Dim i, m, Cubed As Long, lNumb As Integer
Start:
    Asker = InputBox("Enter a positive integer:")
    If Not IsNumeric(Asker) Or InStr(1, Asker, ",") > 0 Then
        If Asker = "" Then Exit Sub
        m = MsgBox("You entered a string! Please, correct!", vbCritical)
        GoTo Start
    End If
    lNumb = Val(Asker)
    Result = ""
    For i = 1 To lNumb
        Cubed = i ^ 3
        If i = lNumb Then
            ending = ""
        Else
            ending = ", "
        End If
        Result = Result & " " & Cubed & ending
    Next i
    m = MsgBox(lNumb & " -> " & Trim(Result), vbInformation)
End Sub
*/