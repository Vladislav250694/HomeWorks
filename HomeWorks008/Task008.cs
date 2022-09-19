// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write ("Введите количество строк массива: ");
int rows = int.Parse (Console.ReadLine());
Console.Write ("Введите количество столбцов массива: ");
int colums = int.Parse (Console.ReadLine());
double[,] numbers = new double[rows, colums];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write ("Введите номер строки: ");
int rows1 = int.Parse (Console.ReadLine());
Console.Write ("Введите номер столбца: ");
int colums1 = int.Parse (Console.ReadLine());
int [,] numbers1 = new int [4,4];
FillArrayRandomNumbers1 (numbers1);

if (rows1 > numbers1.GetLength(0) || colums1 > numbers1.GetLength(1))
{
    Console.WriteLine("Данного элемент не существует");
}
else
{
    Console.WriteLine($"значение элемента {rows1}-й строки и {colums1}-го столбца равно {numbers1[rows1-1,colums1-1]}");
}

PrintArray1(numbers1);

void FillArrayRandomNumbers1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write ("Введите количество строк массива: ");
int rows2 = int.Parse (Console.ReadLine());
Console.Write ("Введите количество столбцов массива: ");
int colums2 = int.Parse (Console.ReadLine());

int[,] numbers3 = new int[rows2, colums2];
FillArrayRandomNumbers3(numbers3);


for (int j = 0; j < numbers3.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers3.GetLength(0); i++)
    {
        avarage = (avarage + numbers3[i, j]);
    }
    avarage = avarage / rows2;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray3(numbers3);



void FillArrayRandomNumbers3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray3(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


