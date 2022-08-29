
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


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int A=Convert.ToInt32(Console.ReadLine());
// int B=Convert.ToInt32(Console.ReadLine());




// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
double Qube1=0;
for (int i=1; i<N+1; i++)
{ 
    Qube1=Math.Pow(i,3);
    Console.WriteLine ("Число возведено в куб: " + Qube1);
}