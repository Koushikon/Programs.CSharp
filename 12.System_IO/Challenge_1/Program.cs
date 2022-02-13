using System;
using System.IO;

/**
 * * Question: Write a program that reads a text file and displays the number of words.
 */

int Count_Words(string[] words)
{
    int count_w = 0;
    for (int i = 0; i < words.Length; i++)
    {
        count_w += words[i].Split(' ').Length;
    }
    return count_w;
}

string[] words = File.ReadAllText(@"./../../_Files/file_1.txt").Split('\n');

int res = Count_Words(words);
Console.WriteLine($"Total words are {res}");