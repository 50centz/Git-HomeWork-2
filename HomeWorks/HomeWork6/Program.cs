void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

/*

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int HowManyNumbersAreGreaterThanZero ()
{   
    int counter = 0;
    Console.WriteLine("The number of numbers entered: ");
    int a = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < a; i++)
    {
        Console.WriteLine("Input a digit: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b > 0) counter++;
    }
    return counter;
}


int result = HowManyNumbersAreGreaterThanZero();
Console.WriteLine();
Console.WriteLine("The number of numbers greater than zero = " + result);
*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];

    double x = -(b1 - b2) / (k1 - k2);
    double a = k1 * x + b1;
    double b = k2 * x + b2;

    a = Math.Round(a, 2);
    b = Math.Round(b, 2);

    array[0] = a;
    array[1] = b;

    return array;
}

Console.WriteLine("Input a b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] array = IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine();
Console.WriteLine("Intersection point " + array[0] + " " + array[1]);
