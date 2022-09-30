/*

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

*/

/*

// Задача  2. Напишите программу, которая на вход принимает одно число (N), а на выход показывает все целые числа  от -N до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if(number > 0)
{
    current = -number;
}
else
{
    current = number;
    number *= -1;
}

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

/*

// Задача 3. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrent input!");
}
*/