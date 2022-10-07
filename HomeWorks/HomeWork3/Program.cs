/*

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Написал программу для двузначных чисел и выше 

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number;
int number1 = number % 10;

if (number < 10)
{
    Console.WriteLine("The number is incorrect");
}
else
{
    while (number > 10)
    {
        number = number / 10;
    }

    if (number == number1)
    {
        Console.WriteLine($"Yes, the number {a} is a palindrome");
    }
    else
    {
        Console.WriteLine($"No, the number {a} is nota palindrome");
    }
}

*/

/*

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Distance(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double d = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(c2 - c1, 2));
    Console.WriteLine(Math.Round(d, 2));
}

Console.WriteLine("Input xA - coordinate");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yA - coordinate");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input cA - coordinate");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xB - coordinate");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yB - coordinate");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input cB - coordinate");
double c2 = Convert.ToDouble(Console.ReadLine());

Distance(x1, y1, c1, x2, y2, c2);

*/



// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("The number is incorrect");
}
else
{
    int a = 1;
    while (a <= number)
    {
        Console.Write(Math.Pow(a, 3) + " ");
        a++;
    }
}