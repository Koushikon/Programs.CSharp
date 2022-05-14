using System;
using System.Collections.Generic;

/**
 * * Question: Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
 */

int Vowels_Count(string word)
{
    Dictionary<char, bool> vowel = new Dictionary<char, bool> {
        {'a', false},
        {'e', false},
        {'i', false},
        {'o', false},
        {'u', false},
    };

    int Vowels_Count = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (vowel.ContainsKey(word[i]))
            Vowels_Count++;
    }
    return Vowels_Count;
}

var word = Console.ReadLine();

if (string.IsNullOrWhiteSpace(word))
    System.Environment.Exit(1);

int res = Vowels_Count(word.ToLower());
Console.WriteLine($"{word} has {res} vowels.");
