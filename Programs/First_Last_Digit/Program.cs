using System;

long InputNum = long.Parse(Console.ReadLine());
int no_of_digit = (int)Math.Log10(InputNum);

static int[] first_last(long num, int digits)
{
    int[] fl_num = new int[2];
    fl_num[0] = (int)Math.Floor(num / Math.Pow(10, digits));
    fl_num[1] = Convert.ToInt32(num % 10);
    return fl_num;
}

int[] result = first_last(InputNum, no_of_digit);
Console.WriteLine($"First Digit: {result[0]} \tLast Digit: {result[1]}");