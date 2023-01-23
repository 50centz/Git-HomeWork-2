/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbersInTheInterval(int a)
{
    Console.Write(a + " ");
    if (a > 1) NaturalNumbersInTheInterval(a - 1);
    Console.Write(" " + a);
}

NaturalNumbersInTheInterval(10);
*/

/*
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
*/

/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return Akker(m - 1, 1);
    else return Akker(m - 1, Akker(m, n - 1));
}

Console.WriteLine(Akker(4, 1));
*/


// Реализовать вывод массива с помощью рекурсии

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

void PrintArray(int[] array, int i)
{   
    if(i >= 8) return;
    
    Console.Write(array[i] + " ");
    i++;
    
    PrintArray(array, i);
    Console.Write(" " + array[i]);
}

PrintArray(array, 0);