

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

/*
Console.WriteLine("Input x - coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y - coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x}, {y}) is on the {FindQuart(x, y)} quart");
*/


// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (x и y)
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// Напишите программу =, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N