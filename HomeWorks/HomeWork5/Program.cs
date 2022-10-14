int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int NumberOfEvenNumbersInTheArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    return sum;
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("The number of even numbers in the array: " + NumberOfEvenNumbersInTheArray(array));
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Sum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        int a = array[i];
        sum += a;
    }
    return sum;
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);  // В этом задании, в методе CreateArray, поменял диапазон рандомных чисел на -1000, 1000.
PrintArray(array);
Console.WriteLine();
Console.WriteLine("The sum of the elements standing in odd positions = " + Sum(array));
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива


double[] CreateNewArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100000);
    }
    return array;
}

void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double TheDifferenceBetweenTheMaximumAndMinimumArrayElement(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }

    double result = max - min;
    return result;
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateNewArray(size);
PrintNewArray(array);
Console.WriteLine();
Console.WriteLine($"The difference between the maximum and minimum array element = " + TheDifferenceBetweenTheMaximumAndMinimumArrayElement(array));
*/



// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] ProductOfPairsOfNumbersInAOneDimensionalArray(int[] array)
{
    int a = array.Length - 1;
    int size = (array.Length + 1) / 2;
    int[] newArray = new int[size];

    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length - i; i++)
        {
            newArray[i] = array[i] * array[a];
            a -= 1;
        }
    }
    else
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[a];
            a -= 1;
        }

    }
    return newArray;
}


Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine();
int[] newArray = ProductOfPairsOfNumbersInAOneDimensionalArray(array);
PrintArray(newArray);