/*

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void RaiseToADegree(int a, int b)
{
    int number = 1;

    if (a < 0 || b < 0)
    {
        Console.WriteLine("The number is incorrect !");

    }
    else
    {
        for (int i = 0; i < b; i++)
        {
            number *= a;
        }
        Console.WriteLine(number);
    }
}

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the degree: ");
int b = Convert.ToInt32(Console.ReadLine());

RaiseToADegree(a, b);

*/




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sum(int number)
{
    int c = number;
    int a = 0;
    int b = 0;
    if (number > 0)
    {
        while (number > 0)
        {
            a = number % 10;
            b = b + a;
            number = number / 10;
        }
        Console.WriteLine($"The sum of the numbers in the number {c} = {b}");
    }
    else
    {
        Console.WriteLine("The number is incorrect !");
    }
}

Console.WriteLine("Input a number: ");
int b = Convert.ToInt32(Console.ReadLine());

Sum(b);

