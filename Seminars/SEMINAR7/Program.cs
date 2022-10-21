// Задайте двумерный массив размером mXn, заполненный случайными целыми числами.

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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


/*
// Задйте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Аij = i+j. Выведите полученный массив на экран.

int[,] CreateNewRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] newArray = CreateNewRandom2dArray();
Show2dArray(newArray);
*/

/*
// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

int[,] CreateNewRandom2dArray()
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

void ArrayElementsSquared(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
}

void Show2dArrayInTheFrame(int[,] array)
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

int[,] newArray = CreateNewRandom2dArray();
Show2dArray(newArray);
Console.WriteLine();
ArrayElementsSquared(newArray);
Show2dArrayInTheFrame(newArray);
*/



// Задайте двумерный массив. Найдите сумму элементов, находящийся на главной диагонали(с индексом(0,0);(1,1) итд)

int SumOfElements2dArray(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }           
        }
    }
    return sum;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine();
int a = SumOfElements2dArray(newArray);
Console.WriteLine(a);