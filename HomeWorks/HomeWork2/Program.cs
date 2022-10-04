/*

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 999)
{
    int n1 = number % 100;
    int n2 = n1 / 10;
    Console.WriteLine(n2);
}
else if (number < -100 && number > -999)
{
    int a1 = number % 100;
    int a2 = a1 / 10;
    int a3 = a2 * -1;
    Console.WriteLine(a3);
}
else
{
    Console.WriteLine("It's not a three digit number");
}

*/

/*

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 1000000 || a < -1000000)
{
    Console.WriteLine("The program works with numbers from -999999 to 999999");
}
if (a > 99 && a < 1000)
{
    Console.WriteLine(a % 10);
}
else if (a < -99 && a > -1000)
{
    int b = a * -1;
    Console.WriteLine(b % 10);
}
else if (a > 1000 && a < 9999)
{
    int b = a % 100;
    Console.WriteLine(b / 10);
}
else if (a < -1000 && a > -9999)
{
    int b = a * -1;
    int c = b % 100;
    Console.WriteLine(c / 10);
}
else if (a > 10000 && a < 99999)
{
    int b = a % 1000;
    Console.WriteLine(b / 100);
}
else if (a < -10000 && a > -99999)
{
    int b = a * -1;
    int c = b % 1000;
    Console.WriteLine(c / 100);
}
else if (a > 100000 && a < 999999)
{
    int b = a % 10000;
    Console.WriteLine(b / 1000);
}
else if (a < -100000 && a > -999999)
{
    int b = a * -1;
    int c = b % 10000;
    Console.WriteLine(c / 1000);
}
else
{
    Console.WriteLine("There is no third digit");
}

*/


/*

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Enter the number indicating the day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7 || a < 1)
{
    Console.WriteLine("The number is incorrect");
}
else if (a == 6 || a == 7)
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Working day");
}

*/