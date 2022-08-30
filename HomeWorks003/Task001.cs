
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

int x1 = Coordinate ("x","A");
int y1 = Coordinate ("y","A");
int z1 = Coordinate ("z","A");
int x2 = Coordinate ("x","B");
int y2 = Coordinate ("y","B");
int z2 = Coordinate ("z","B");

double rast = Math.Round((Rasstoyanie(x1,y1,z1,x2,y2,z2)),2);
Console.WriteLine($"Длина отрезка {rast}");

int Coordinate(string coor, string tochka)
{
    Console.Write($"Введите координату {coor} точки {tochka}: ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    return vvod;
}


double Rasstoyanie (double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{ 
    double answer = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
    return answer;
}


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
Qube1(N);

void Qube1(int N)
{
double Qube1=0;
for (int i=1; i<N+1; i++)
{ 
    Qube1=Math.Pow(i,3);
    Console.WriteLine ("Число возведено в куб: " + Qube1);
}
}

