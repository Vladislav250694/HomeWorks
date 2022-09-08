// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] FilArr(int lengthArr)
{
    System.Random numberGen = new System.Random();
    int k = 0;
    int [] outArr = new int [lengthArr];
    while (k<lengthArr)
    {
        outArr[k] = numberGen.Next(100,1000);
        k++;
    }
    return outArr;
}

void Print1DArr (int[] inputArr)
{
    int k = 0;
    while (k<inputArr.Length-1)
    {
        Console.Write(inputArr[k]+", ");
        k++;
    }
    Console.Write(inputArr[k]);
}

int [] array = FilArr(6);
Print1DArr(array);

int count = 0;
for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.Write($"\nВсего: {array.Length} чисел, {count} из них чётные");