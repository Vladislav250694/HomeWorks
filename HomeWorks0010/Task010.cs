// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите положительное число N: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число M: ");
int max = Convert.ToInt32(Console.ReadLine());
PrintNumber(min, max);

void PrintNumber (int min, int max)
{
    if (min <=max)
    {
        Console.Write($"{min}  ");
        PrintNumber (min+1, max);
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("\nВведите число M: ");
int numberM1 = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN1 = int.Parse(Console.ReadLine());

SumFromMToN(numberM1, numberN1);

void SumFromMToN(int numberM1, int numberN1)
{
    Console.Write(SumMN(numberM1 - 1, numberN1));
}
int SumMN(int numberM1, int numberN1)
{
    int res = numberM1;
    if (numberM1 == numberN1)
        return 0;
    else
    {
        numberM1++;
        res = numberM1 + SumMN(numberM1, numberN1);
        return res;
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("\nВведите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
