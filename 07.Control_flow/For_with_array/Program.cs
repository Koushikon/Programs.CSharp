using System;

/*************
 * C# For loop with Arrays
*************/

// Printing out the Character array 
char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
for (int i = 0; i < vowels.Length; ++i)
    Console.Write($"{vowels[i]} ");
Console.WriteLine("\n");

// Double and String array printing
double[] hi_temps = new double[] { 90.1, 67.3, 33.1, 42.8 };
for (int i = 0; i < hi_temps.Length; ++i)
    Console.Write($"{hi_temps[i]} ");
Console.WriteLine("\n");

string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
for (int i = 0; i < weekDays.Length; ++i)
    Console.Write($"{weekDays[i]} ");
Console.WriteLine("\n");

// Initializing the entire array
int[] nums = new int[10] { 5, 6, 7, 2, 1, 6, 9, 8, 7, 4 };

for (int i = 0; i < nums.Length; ++i) // Print the array
    Console.Write($"{nums[i]} ");
Console.WriteLine();

Console.WriteLine("After Reinitializing the entire array:");
for (int i = 0; i < nums.Length; ++i)
    nums[i] = 15;

for (int i = 0; i < nums.Length; ++i) // After changing print the array
    Console.Write($"{nums[i]} ");
Console.WriteLine("\n");


int row = 5, column = 2;
double[,] matrix = new double[row, column];
int value = 17;

// Initializing the matrix
for (int i = 0; i < row; ++i)
    for (int j = 0; j < column; ++j)
        matrix[i, j] = value++;

// Printing the matrix
for (int i = 0; i < row; ++i)
{
    for (int j = 0; j < column; ++j)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
}