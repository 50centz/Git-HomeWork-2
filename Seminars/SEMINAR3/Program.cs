/*

// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y !=0 и выдаёт номер четверти плоскости, в которй находится эта точка

int FindQuart(double x, double y)
{
    int quart = 0;

    if (x > 0 && y > 0) quart = 1;
    if (x < 0 && y > 0) quart = 2;
    if (x < 0 && y < 0) quart = 3;
    if (x > 0 && y < 0) quart = 4;
    return quart;
}

Console.WriteLine("Input x coordinates :");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y coordinates :");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(FindQuart(x, y));
*/

/*
Console.WriteLine("Input x - coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y - coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x}, {y}) is on the {FindQuart(x, y)} quart");
*/

/*

// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 4 || a < 1)
{
    Console.WriteLine("The number is not correct");
}
if (a == 1) Console.WriteLine("x, y");
if (a == 2) Console.WriteLine("-x, y");
if (a == 3) Console.WriteLine("-x, -y");
if (a == 4) Console.WriteLine("x, -y");

*/

/*

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// Формула: Квадратный корень из AC в квадрате BC в квадрате

void Distance(double x1, double y1, double x2, double y2)
{
    double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine(Math.Round(d, 2));
}

Console.WriteLine("Input xA coordinat");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input yA coordinat");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input xB coordinat");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input yB coordinat");
double yB = Convert.ToInt32(Console.ReadLine());

Distance(xA, yA, xB, yB);

*/

// Напишите программу =, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N

void SquareOfNumbers(int number)
{
    int a = 1;

    if (number < 1)
    {
        Console.WriteLine("The number is incorrect");
    }
    else
    {
        while (a <= number)
        {
            Console.Write(Math.Pow(a, 2) + " ");
            a++;
        }
    }
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

SquareOfNumbers(a);