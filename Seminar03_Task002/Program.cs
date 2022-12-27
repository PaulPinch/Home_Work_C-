/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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
            Console.WriteLine("Ввели не число (x, y). Повторите ввод!");
        }
    }

    return result;
}


int x1 = GetNumber("Введите координату x1: ");
int y1 = GetNumber("Введите координату y1: ");
int z1 = GetNumber("Введите координату z1: ");

int x2 = GetNumber("Введите координату x2: ");
int y2 = GetNumber("Введите координату y2: ");
int z2 = GetNumber("Введите координату z2: ");

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + (Math.Pow(y2-y1, 2))+(Math.Pow(z2-z1, 2)));

Console.WriteLine(result);

/*
Решение задачи на VBA для Excel:
Sub Sem3Task21()
 'Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Dim Asker As String, m, i, s
    Dim cLabel As String, Result As Double
    Dim fP(3) As Double, sP(3) As Double
    For s = 1 To 2
        For i = 1 To 3
            Select Case i
                Case 1
                    cLabel = "X" & s
                Case 2
                    cLabel = "Y" & s
                Case 3
                    cLabel = "Z" & s
            End Select
Start:
            Asker = InputBox("Enter a coordinate for " & cLabel & ":")
            If Not IsNumeric(Asker) Then
                If Asker = "" Then Exit Sub
                m = MsgBox("You entered a string! Please, correct!", vbCritical)
                GoTo Start
            End If
            If s = 1 Then
                fP(i) = Val(Asker)
            Else
                sP(i) = Val(Asker)
            End If
        Next i
    Next s
    Result = Sqr((sP(1) - fP(1)) ^ 2 + (sP(2) - fP(2)) ^ 2 + (sP(3) - fP(3)) ^ 2)
    m = MsgBox("The 3-D distance between the points is " & Round(Result, 2), vbInformation)
End Sub
*/