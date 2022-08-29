
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.Write("Введите пятизначное число: ");
string Number = (Console.ReadLine());
Console.WriteLine (Palindrom(Number));

string Palindrom (string Number)
{
    if (Number[0]==Number[4] && Number [1]==Number [3])
        return "Ввведенное число является палиндромом";
    else
        return "Введенное число не является палиндромом";
   return "не то что нужно";
}
