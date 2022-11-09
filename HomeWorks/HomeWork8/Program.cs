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

/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] OrderingArrayElementsInDescendingOrder(int[,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
OrderingArrayElementsInDescendingOrder(myArray);
Show2dArray(myArray);
*/

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

/*
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
*/

/*
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateNewRandom3dArray()
{
    Console.WriteLine("Dimension of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,,] myArray = new int[size, row, columns];
    int[] array = new int[size * row * columns];

    if (size * row * columns < 90)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10, 100);

            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (array[i] == array[j])
                    {
                        array[i] = new Random().Next(10, 100);
                        j = 0;
                    }
                }
            }
        }
        int count = 0;
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                for (int k = 0; k < myArray.GetLength(2); k++)
                {
                    myArray[i, j, k] = array[count];
                    count++;
                }
            }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("The array cannot be filled with non-repeating numbers");
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                for (int k = 0; k < myArray.GetLength(2); k++)
                {
                    myArray[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }

    return myArray;
}


void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Array № " + (i + 1));

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] myArray3d = CreateNewRandom3dArray();
Console.WriteLine();
Show3DArray(myArray3d);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] FillTheArrayInASpiral()
{
    Console.WriteLine("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    int count = 1;

    for (int i = 0; count <= rows * columns; i++)
    {
        for (int a = i; a < columns - i; a++)
        {
            array[i, a] = count++;
        }
        for (int b = i + 1; b < rows - i; b++)
        {
            array[b, columns - 1 - i ] = count++;
        }
        for (int c = columns - i - 2; c >= i; c--)
        {
            array[rows - i - 1, c] = count++;   
        }
        for (int d = rows - i - 2; d > i; d--)
        {
            array[d, i] = count++;
        }
        
    }

    return array;
}


int[,] array = FillTheArrayInASpiral();
Show2dArray(array);