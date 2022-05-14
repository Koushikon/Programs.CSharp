using System;
using System.IO;

/**
 * * Question: Write a program that reads a text file and displays the longest word in the file.
 */

string Count_Words(string[] words)
{
    string long_word = "";
    for (int i = 0; i < words.Length; i++)
    {
        string[] n_words = words[i].Split(' ');
        for (int j = 0; j < n_words.Length; j++)
        {
            if (long_word.Length < n_words[j].Length)
                long_word = n_words[j];
        }
    }
    return long_word;
}

string[] words = File.ReadAllText(@"./../../_Files/file_1.txt").Split('\n');

string res = Count_Words(words);
Console.WriteLine($"Longest word is {res}");