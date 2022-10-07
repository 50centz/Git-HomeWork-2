int FindBiggestDigit(int num)
{
    int max;
    //int num = new Random().Next(10, 100);

    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}

/*
int number = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int TwoDigitNumber(int num)
{
    int result;
    
    int ed = num % 10;
    int dec = num / 100;

    result = dec * 10 + ed;    

    return result;
}

/*
int number = new Random().Next(100, 1000);
int twoDigitNumber = TwoDigitNumber(number);

Console.WriteLine("Number is: " + twoDigitNumber);
*/


// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool MultipleNumber(int number, int a, int b)
{
    bool result;

    if (number % a == 0 && number % b == 0 )
    {
      result = true;
    }
    else
    {
        result = false;
    }
    
    return result; 
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first divisor ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second divisor");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultipleNumber(number, a, b);
Console.WriteLine(res);