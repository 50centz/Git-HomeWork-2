/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int a = new Random().Next(minValue, maxValue + 1);
            array[i, j] = new Random().NextDouble() * a;
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/


/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void ThereIsNoSuchElement()
{
    Console.WriteLine("There are no numbers with such indexes in the array");
}

void ReturnTheValueOfTheElement(int[,] array, int a, int b)
{
    if (a <= array.GetLength(0) && b <= array.GetLength(1))
    {
        Console.WriteLine(array[a - 1, b - 1]);
    }
    else
    {
        ThereIsNoSuchElement();
    }

}
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

double[] ArithmeticMean(int[,] array)
{
    int a = 0;
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        newArray[a] = Math.Round(sum / array.GetLength(0), 2);
        a++;
        sum = 0;
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

int[,] array = CreateRandom2dArray();
double[] newArray = ArithmeticMean(array);
Console.WriteLine();
Show2dArray(array);
Console.WriteLine();
ShowArray(newArray);