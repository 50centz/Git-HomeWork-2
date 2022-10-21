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



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void ThereIsNoSuchElement()
{
    Console.WriteLine("There is no such element");
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