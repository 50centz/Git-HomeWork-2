

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Написал программу для двузначных чисел и выше 
  
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number;
int number1 = number % 10;

if (number < 10)
{
    Console.WriteLine("The number is incorrect");
}
else
{
    while (number > 10)
    {
        number = number / 10;
    }

    if (number == number1)
    {
        Console.WriteLine($"Yes, the number {a} is a palindrome");
    }
    else
    {
        Console.WriteLine($"No, the number {a} is nota palindrome");
    }
}


