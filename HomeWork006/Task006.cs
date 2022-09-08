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

Console.Write($"\nВсего: {array.Length} чисел, {count} из них чётные \n");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int [] FilArr1(int lengthArr1)
{
    System.Random numberGen1 = new System.Random();
    int k1 = 0;
    int [] outArr1 = new int [lengthArr1];
    while (k1<lengthArr1)
    {
        outArr1[k1] = numberGen1.Next(1,100);
        k1++;
    }
    return outArr1;
}

void PrintOneDArr (int[] inputArr1)
{
    int k1 = 0;
    while (k1<inputArr1.Length-1)
    {
        Console.Write(inputArr1[k1]+", ");
        k1++;
    }
    Console.Write(inputArr1[k1]);
}
int [] array1 = FilArr1(9);
PrintOneDArr(array1);

int count1 = 0;
int sum = 0;
for (int z1 = 0; z1 < array1.Length; z1++)
if (array1[z1] % 2 == 1)
{
    sum+=array1[z1];
}
count1++;

Console.Write($"\nВсего: {array1.Length} чисел,  сумма нечетных {sum} \n");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double [] FilArr2(int lengthArr2)
{
    System.Random numberGen2 = new System.Random();
    int k2 = 0;
    double [] outArr2 = new double [lengthArr2];
    while (k2<lengthArr2)
    {
        outArr2[k2] = numberGen2.Next(1,100);
        k2++;
    }
    return outArr2;
}

void PrintTwoDArr (double[] inputArr2)
{
    int k2 = 0;
    while (k2<inputArr2.Length-1)
    {
        Console.Write(inputArr2[k2]+", ");
        k2++;
    }
    Console.Write(inputArr2[k2]);
}
double [] array2 = FilArr2(12);
PrintTwoDArr(array2);

double max = 0;
double min = 100;
for (int z2 = 0; z2 < array2.Length; z2++)
{
    if (array2[z2] > max)
        {
            max = array2[z2];
        }
    if (array2[z2] < min)
        {
            min = array2[z2];
        }
}
Console.Write($"\nМаксимальный элемент = {max}, минимальный элемент = {min}");
Console.Write($"\nРазность между максимальным и минимальным элементами из массива = {max-min}");


