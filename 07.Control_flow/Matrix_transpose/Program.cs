using System;

/*************
 * Matrix transpose
*************/

int rows = 0, columns = 0;
string userInput;

// Take row input
Console.Write("Enter the rows: ");
userInput = Console.ReadLine();
rows = Convert.ToInt32(userInput);

// Take column input
Console.Write("Enter the columns: ");


userInput = Console.ReadLine();
columns = Convert.ToInt32(userInput);
double[,] matrix = new double[rows, columns];

// Taking the matrix input
for (int i = 0; i < rows; ++i)
    for (int j = 0; j < columns; ++j)
    {
        Console.Write("Enter the value for matrix [{0}][{1}]: ", i, j);
        userInput = Console.ReadLine();
        matrix[i, j] = Convert.ToDouble(userInput);
    }

Console.WriteLine($"rows {rows} columns {columns}");

// Printing the matrix
Console.WriteLine("The Matrix:");
for (int i = 0; i < rows; ++i)
{
    for (int j = 0; j < columns; ++j)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
}

// Printing the matrix transpose
Console.WriteLine("The Matrix:");
for (int i = 0; i < columns; ++i)
{
    for (int j = 0; j < rows; ++j)
        Console.Write($"{matrix[j, i]} ");
    Console.WriteLine();
}

Console.Write("The end...");
Console.ReadKey();
