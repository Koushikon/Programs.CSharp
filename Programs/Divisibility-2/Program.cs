using System;

int value = int.Parse(Console.ReadLine());
string[] str_arr = Console.ReadLine().Split(' ');

// Must be same no. of element as userInput and Check Constraints
if (value != str_arr.Length && (value < 1 || value > 100000))
    System.Environment.Exit(1);

int half = str_arr.Length / 2;
int[] results = new int[2];

for (int i = 0; i < str_arr.Length; i++)
{
    if (i < half)
    {
        // value = int.Parse(str_arr[i][0].ToString());
        value = (int)Char.GetNumericValue(str_arr[i][0]);
    }
    else
    {
        // value = int.Parse(str_arr[i][str_arr[i].Length - 1].ToString());
        value = (int)Char.GetNumericValue(str_arr[i][str_arr[i].Length - 1]);
    }

    if (i % 2 == 0)
    {
        results[0] += value;
        Console.WriteLine($"Even = {results[0]}");
    }
    else
    {
        results[1] += value;
        Console.WriteLine($"Odd = {results[1]}");

    }
}

value = Math.Abs(results[0] - results[1]);
// Console.WriteLine((value % 11 == 0) ? "OUI" : "NON");
Console.WriteLine((value == 0) ? "OUI" : "NON");
