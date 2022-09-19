// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write ("Введите количество строк массива: ");
int rows = int.Parse (Console.ReadLine());

Console.Write ("Введите количество столбцов массива: ");
int colums = int.Parse (Console.ReadLine());


int[,] numbers = new int[rows, colums];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Созданный массив до упорядочивания");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Write ("Введите количество строк массива: ");
int rows1 = int.Parse (Console.ReadLine());

Console.Write ("Введите количество столбцов массива: ");
int colums1 = int.Parse (Console.ReadLine());

int[,] numbers1 = new int[rows1, colums1];
FillArrayRandomNumbers1(numbers1);
PrintArray1(numbers1);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers1.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers1.GetLength(1); j++)
    {
        sum = sum + numbers1[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Cтрока с наименьшей суммой элементов под номером: " + (indexLine) + ", сумма которых =  " + (minsum));

void FillArrayRandomNumbers1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}