using System;

/**
 * * Finding Factorial Value
 */

static int getFactorial(int num)
{
    int sum = 1;
    for (int i = 0; i < num; i++)
    {
        sum *= num - i;
        // Console.WriteLine("{0} {1} {2}", i, num - i, sum);
    }
    return sum;
}

int number = int.Parse(Console.ReadLine());

int value = getFactorial(number);
Console.WriteLine($"{number}'s factorial is {value}");