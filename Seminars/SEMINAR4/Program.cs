

// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int GetSum(int a)
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
    {
        sum += current;
    }
    return sum;
}

/*
Console.Write("Input positive integer number : ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);
Console.WriteLine($"Sum of number from 1 to {num} is {s}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumberOfDigits(int number)
{
    int a = number.ToString().Length;
    return a;
}


/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = NumberOfDigits(num);
Console.WriteLine($"The number {num} consists of {a} digits");

// int a = num.ToString().Length;
*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetMultiplication(int a)
{
    int sum = 1;

    for (int current = 1; current <= a; current++)
    {
        sum *= current;
    }
    return sum;
}

/*
Console.Write("Input positive integer number : ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetMultiplication(num);
Console.WriteLine($"Sum of number from 1 to {num} is {s}");
*/

// Напишите программу, которая выводит массив из M элементов, заполненный нулями и единицами в случайном порядке

int[] CreateRandomArray(int size, int minValue, int maxValue)
{   
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
} 


void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = 50;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
