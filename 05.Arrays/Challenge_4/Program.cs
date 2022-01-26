using System;
using System.Collections.Generic;

/**
 * * Take some numbers and display only the unique numbers between them
 */

Dictionary<int, int> isHave = new Dictionary<int, int>();
string input = "";
int value = 0;

do
{
    Console.Write("Enter the number: ");
    input = Console.ReadLine();
    try
    {
        int num = Convert.ToInt32(input);
        if (isHave.TryGetValue(num, out value))
        {
            isHave[num] = value + 1;
        }
        else
        {
            isHave.Add(num, 1);
        }
    }
    catch
    {
        continue;
    }
} while (input.ToLower() != "quit");

Console.WriteLine(string.Join(' ', isHave.Keys));
