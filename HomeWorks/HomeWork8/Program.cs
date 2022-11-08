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
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int FindRow(int[,] array)
{
    int sum = 0;
    int result = 0;
    int numberString = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[0, j];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (result > sum)
        {
            result = sum;
            numberString = i;
        }
        sum = 0;
    }
    return numberString + 1;

}

int[,] myArray = CreateRandom2dArray();
int numberRow = FindRow(myArray);
Console.WriteLine();
Console.WriteLine($"The smallest sum of elements in {numberRow} lines");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] ProductOfTwoMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] resultArray = new int[2, 2];

    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        Console.WriteLine("Matrix multiplication is not possible !");
        return resultArray ;
    }
    
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            resultArray[i, j] = 0;

            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                resultArray[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return resultArray;
}

int[,] arrayA = CreateRandom2dArray();
int[,] arrayB = CreateRandom2dArray();
Show2dArray(arrayA);
Console.WriteLine();
Show2dArray(arrayB);
int[,] resultArray = ProductOfTwoMatrices(arrayA, arrayB);
Console.WriteLine();
Show2dArray(resultArray);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

