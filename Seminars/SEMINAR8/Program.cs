
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
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


void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}
/*
void ChangeArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("It`s impossible !!!!");
    }
}
*/


/*
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = array[0, j];
        array[0, j] = temp;

    }
}

int[,] myArray = Create2DArrayRandomInt(5, 10, 10, 100);
Print2DArrayInt(myArray);
Console.WriteLine();
ChangeArray(myArray);
Print2DArrayInt(myArray);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] DeleteRowAndColumns(int[,] array)
{
    int[,] myArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int min = array[0, 0];
    int iMin = 0;
    int jMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }


    for (int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if (i == iMin)
        {
            m--;
            continue;
        }
        for (int j = 0, n = 0; j < array.GetLength(1); j++, n++)
        {
            if (j == jMin)
            {
                n--;
                continue;
            }
            myArray[m, n] = array[i, j];
        }
    }

    return myArray;
}

int[,] array = Create2DArrayRandomInt(5, 5, 1, 9);
Print2DArrayInt(array);
Console.WriteLine();
int[,] newArray = DeleteRowAndColumns(array);
Print2DArrayInt(newArray);