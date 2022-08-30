// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B=Convert.ToInt32(Console.ReadLine());
Construction(A,B);

void Construction(int A,int B)
{
double Construction=0;

{ 
    Construction=Math.Pow(A,B);
    Console.WriteLine ($"Число {A} возведено в степень {B} = {Construction} ");
}
}