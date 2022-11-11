/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbersInTheInterval (int count)
{
    Console.Write(count + " ");
    if(count > 1)
    {
        count--;
        NaturalNumbersInTheInterval(count);
    }
}

Console.WriteLine("Input a number: ");
int digit = Convert.ToInt32(Console.ReadLine());
NaturalNumbersInTheInterval(digit);
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int TheSumOfNaturalElements(int m, int n)
{
    int sum = 0;

    Console.Write($"{m} and {n}  ");
    if (m < n)
    {
        m++;
        TheSumOfNaturalElements(m, n);
    }
    sum += m;
    return sum;
}

int a = 1;
int b = 15;

int sum = TheSumOfNaturalElements(a, b);
Console.WriteLine();
Console.WriteLine(sum);