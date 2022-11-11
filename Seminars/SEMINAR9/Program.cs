/*
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(5);
*/

/*
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfdigits(int num)
{
    if(num != 0) return SumOfdigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfdigits(1234));
*/

/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumbers(int m, int n)
{
    if (m < n)
    {
        PrintNumbers(m, n - 1);
        Console.Write($"{n} ");
    }
    if (m > n)
    {
        PrintNumbers(m - 1, n );
        Console.Write($"{m} ");
    }
    if (m == n)
    {
        Console.Write(m + " ");
    }
}

PrintNumbers(6, 2);
*/


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double PowerAB( double a, double b)
{
    if(b < 0) return (1/a) * PowerAB(a, b + 1);  // a ^ 
    if(b > 0) return a * PowerAB(a, b - 1);
    else return 1;
}

Console.WriteLine(PowerAB(2, 3));


