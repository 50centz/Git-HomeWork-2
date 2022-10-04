

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
