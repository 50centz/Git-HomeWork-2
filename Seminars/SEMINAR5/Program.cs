

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete !");
    return array;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int SumOfNegatives(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Console.WriteLine("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// int result = SumOfNegatives(myArray);

// ShowArray(myArray);
// Console.WriteLine("Sum of a negative elements is " + result);


// Напишите программу замена элементов массива: положительные элементы замените на соотвествующие отрицательные и наоборот.  [-4, -8, 8, 2] -> [4, 8, -8, -2].

int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i] + " ");
    }
    return array;
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
}

// Console.WriteLine("Input a number: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateNewArray(size);
// Console.WriteLine();
// ChangeArray(array);

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

// Console.WriteLine("Input a size array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateNewArray(size);
// Console.WriteLine();
// Console.WriteLine(FindNumber(array, number));



// Задайте одномерный массив из 12 случайных чисел. Надйдите количество элементов массива, значения которых лежит в отрезке [10, 99]


int FindNumberOfElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100) sum++;
    }
    return sum;
}

int size = 12;
int[] array = CreateNewArray(size);
Console.WriteLine();
Console.WriteLine(FindNumberOfElements(array));