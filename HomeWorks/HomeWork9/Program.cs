/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbersInTheInterval(int a)
{
    Console.Write(a + " ");
    if (a > 1) NaturalNumbersInTheInterval(a - 1);
}

NaturalNumbersInTheInterval(10);
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumDigits(int m, int n)
{
    if (m > n) return SumDigits(m, n + 1) + n;
    if (m < n) return SumDigits(m, n - 1) + n;
    else return n;
}

int a = SumDigits(15, 1);
Console.WriteLine();
Console.WriteLine(a);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.