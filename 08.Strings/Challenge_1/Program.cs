using System;

/**
 * * Consecutive Number Checking Increment or Decrement Order
 * * Without Continues Manner i.e. 5-8-9-25 or 20-18-15-11-9
 */

bool checkConsecutive(string[] word)
{
    // Console.WriteLine(string.Join(' ', word));

    if (word.Length <= 1)
        return true;

    int num1 = Convert.ToInt32(word[0]);
    int num2 = 0;
    int count = 0;

    for (int i = 1; i < word.Length; i++)
    {
        // Console.WriteLine("{0} {1}", i, word.Length);
        num2 = Convert.ToInt32(word[i]);
        if (num2 > num1)
        {
            count++;
        }
        else if (num2 < num1)
        {
            count--;
        }
        num1 = num2;
    }

    return (Math.Abs(count) == word.Length - 1) ? true : false;
}

/**
 * * Consecutive Number Checking Increment or Decrement Order
 * * With Continues Manner i.e. 5-6-7-8-9 or 20-19-18-17-16
 */

bool checkConsecutive_Continues(string[] word)
{
    var num_con = Array.ConvertAll(word, s => Convert.ToInt32(s));
    var n_size = num_con.Length;

    if (n_size <= 1)
        return true;

    var count = 0;

    for (var i = 0; i < n_size - 1; i++)
    {
        if (num_con[i + 1] == num_con[i] + 1)
        {
            count++;
        }
        else if (num_con[i + 1] == num_con[i] - 1)
        {
            count--;
        }
    }

    return (Math.Abs(count) == n_size - 1) ? true : false;
}

var words = Console.ReadLine().Split('-');

if (string.IsNullOrWhiteSpace(words[0]))
    System.Environment.Exit(1);

bool signal = checkConsecutive(words);
Console.WriteLine("Its Not Continues & {0}", (signal == true) ? "Consecutive" : "Not Consecutive");

signal = checkConsecutive_Continues(words);
Console.WriteLine("Its Continues & {0}", (signal == true) ? "Consecutive" : "Not Consecutive");