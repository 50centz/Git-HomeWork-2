int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
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
