/*

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Enter the first integer: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second integer: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = 1;
int min = -1;

if (n1 > n2)
{
    max = n1;
    min = n2;
}
else
{
    max = n2;
    min = n1;
}

Console.WriteLine("Max number is " + max);
Console.Write("Min number is " + min);

*/


/*

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Enter the first integer: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second integer: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third integer: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (max < n2)
{
    max = n2;
}
if (max < n3)
{
    max = n3;
}

Console.Write("Max number is " + max);


*/


/*

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is not even");
}


*/


/*


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = 1;

if (n1 == number)
{
    Console.WriteLine("There are no even numbers");
}

while (n1 <= number )
{
    if (n1 % 2 != 1)
    {
        Console.Write(n1 + "  ");
    }

    n1++;
}

*/
