

// Напишите программу, которая перевернёт одномерный массив(последний эдемент будет на первом месте, а первый - на последнем итд.)

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



// int ChangeFirstElement(int[] array)
// {
//     array[0] += 5;

//     return array;
// }

void ChangeNumber(int a)
{
    a += 5;
    Console.WriteLine(a);
}

// int num = 5;

// ChangeNumber(num);
// Console.WriteLine(num);


void ReverseArray(int[] array)
{
    for (int i = 0, last = array.Length - 1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;

    }
}

/*
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины (каждая сторона треугольника должна быть строго меньше двух других)

bool ThereIsATriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Enter the size of the first side of the triangle: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of the second side of the triangle: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of the third side of the triangle: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = ThereIsATriangle(a, b, c);
Console.WriteLine($"Triangle with sides: {a}, {b}, {c} - {result}");
*/


/*
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int size = 10;
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine();
int[] newArray = CopyArray(array);
ShowArray(newArray);
*/



// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b

int[] Fibonacchi(int a, int b, int size)
{
    int[] newArray = new int[size];
    newArray[0] = a;
    newArray[1] = b;

    for (int i = 2; i < newArray.Length; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[i - 2];
    }
    return newArray;
}

Console.WriteLine("Input a size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second digit: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = Fibonacchi(a, b, size);
ShowArray(array);