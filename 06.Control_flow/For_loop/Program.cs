using System;

/*************
 * C# For loop implementations
*************/

// Example -1
for (int i = 1; i <= 10; ++i)
    Console.Write($"{i} ");

Console.WriteLine();

// Example -2
for (int i = 1; i <= 10; i += 2)
    Console.Write($"{i} ");

Console.WriteLine();

// Example -3
for (int i = 10; i > 0; --i)
    Console.Write($"{i} ");
Console.WriteLine("\nBlastoff!!");

Console.WriteLine();

// Example -4
for (int i = 10; i <= 100; i += 10)
{
    if (i % 15 == 0)
        Console.Write($"{i}\t");
}

Console.WriteLine();

// Example -5
for (int i = 1, j = 5; i <= 5; ++i, ++j)
    Console.WriteLine($"{i} + {j} = {i + j}");

Console.WriteLine();

// Example -6
for (int i = 1, j = 2, k = 3; i <= 5; ++i, ++j, ++k)
    Console.WriteLine($"{i} * {j} * {k} = {i * j * k}.00");

Console.WriteLine();

// Example -7
for (int i = 1; i <= 100; ++i)
{
    Console.Write(i);
    if (i % 10 == 0)
        Console.WriteLine();
    else
        Console.Write(" . ");
}

Console.WriteLine();

// Example -8
for (int i = 1; i <= 100; ++i)
{
    Console.Write(i);
    Console.Write(i % 10 == 0 ? "\n" : " . ");
}
