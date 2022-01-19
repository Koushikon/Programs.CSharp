using System;

for (byte i = 1; i <= 10; ++i)
{
    for (byte j = 1; j <= i; ++j)
        Console.Write(" * ");
    Console.WriteLine();
}

for (byte i = 0; i <= 10; ++i)
{
    for (byte j = 1; j <= 9 - i; ++j)
        Console.Write(" * ");
    Console.WriteLine();
}