/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbersInTheInterval(int a)
{
    Console.Write(a + " ");
    if (a > 1) NaturalNumbersInTheInterval(a - 1);
}

NaturalNumbersInTheInterval(10);
*/

/*
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
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.