using System;

/**
 * * Find How Many Numbers Between 1 and 100 and Divisible by 3.
 */

const int LBound = 0;
const int UBound = 100;

int Divisible_Count = 0;
for (int i = LBound; i < UBound; i++)
{
    if (i % 3 == 0)
    {
        Console.Write("{0} ", i);
        Divisible_Count += 1;
    }
}

Console.WriteLine($"\nBetween 1 and 100 there are {Divisible_Count} numbers Divisible by 3.");