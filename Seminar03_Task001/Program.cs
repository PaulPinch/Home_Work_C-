
/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            string temp = Convert.ToString(result);
            if (temp.Length == 5)
            {
                break;    
            }
            else
            {
                Console.WriteLine("Ввели не 5-значное положительное число");    
            }
        }
        else
        {
            Console.WriteLine("Ввели не 5-значное положительное число");
        }
    }
    return result;
}
int number = GetNumber("Введите 5-значное положительное число:");
string forward = Convert.ToString(number);
string reversed = new string(forward.ToCharArray().Reverse().ToArray());
if (forward == reversed)
{
    System.Console.WriteLine("Введенное число - ПАЛИНДРОМ!");
}
else
{
    System.Console.WriteLine("Введенное число НЕ палиндром!");
}

/*
Решение задачи на VBA для Excel:
Sub Sem3Task19()
 'Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Dim Asker As String, m
Start:
    Asker = InputBox("Enter a positive 5-digit number:")
    If Not IsNumeric(Asker) Or InStr(1, Asker, ",") > 0 Then
        If Asker = "" Then Exit Sub
        m = MsgBox("You entered a string! Please, correct!", vbCritical)
        GoTo Start
    ElseIf Len(Asker) <> 5 Or InStr(1, Asker, "-") > 0 Then
        m = MsgBox("The number must be a 5-digit positive number! Please, correct!", vbCritical)
        GoTo Start
    End If
    If Asker = StrReverse(Asker) Then
        m = MsgBox("Congratulations! The number you entered IS a palindrome!", vbInformation)
    Else
        m = MsgBox("Sorry! The number you entered is NOT a palindrome!", vbExclamation)
    End If
End Sub
*/





