

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
