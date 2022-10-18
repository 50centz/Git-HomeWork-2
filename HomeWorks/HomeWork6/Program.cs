void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

/*

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int HowManyNumbersAreGreaterThanZero ()
{   
    int counter = 0;
    Console.WriteLine("The number of numbers entered: ");
    int a = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < a; i++)
    {
        Console.WriteLine("Input a digit: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b > 0) counter++;
    }
    return counter;
}


int result = HowManyNumbersAreGreaterThanZero();
Console.WriteLine();
Console.WriteLine("The number of numbers greater than zero = " + result);
*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

