using System;

bool FindDuplicate(string[] word)
{
    var n_word = Array.ConvertAll(word, s => Convert.ToInt32(s));
    int size = n_word.Length;

    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if (n_word[i] == n_word[j])
                return true;
        }
    }
    return false;
}

var words = Console.ReadLine().Split('-');

if (string.IsNullOrWhiteSpace(words[0]))
    System.Environment.Exit(1);

Console.WriteLine("{0} Duplicate", (FindDuplicate(words)) ? "Found" : "Not Found");