// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int [] inputNums()
{
    System.Console.WriteLine ("Введите положительные и отрицательные числа через пробел: ");

    string temp = Console.ReadLine();
    string [] s = temp.Split (' ');
    int [] nums = new int [s.Length];

    for (var i = 0; i < s.Length; i++)
    {
        nums[i] = Convert.ToInt32(s[i]);
    }
    return nums;
}

void printCountPositiveNums(int[] nums)
{
    int count = 0;
    for (var i=0; i<nums.Length; i++)
    {
        if (nums[i]>0) count++;
    }
    System.Console.WriteLine($"введено положительных чисел : {count}.");
}
printCountPositiveNums (inputNums());


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] inputNums1()
{ 
    System.Console.WriteLine ("Введите 4 числа через пробел соответсвенно b1 k1 b2 b k2 :");
    string[] stringNums = Console.ReadLine().Split(' ');
    double[] nums = new double [stringNums.Length];

    for (var i=0; i < stringNums.Length; i++)
    {
        nums[i] = Convert.ToDouble(stringNums[i]);
    }
    return nums;
}

void printFn (double [] nums)
{
    double b1 = nums[0];
    double k1 = nums[1];
    double b2 = nums[2];
    double k2 = nums[3];

    double x = (b2-b1)/ (k1 -k2);
    double y = k1 *x +b1;

    System.Console.WriteLine($"Точка пересечения прямых: ({x}, {y}) ");
}

printFn (inputNums1() );