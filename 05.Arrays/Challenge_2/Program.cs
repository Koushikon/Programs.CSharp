using System;

string userInput = Console.ReadLine();
char[] words = new char[userInput.Length];

for (int i = 0; i < userInput.Length; i++)
{
    words[i] = userInput[userInput.Length - i - 1];
}

Console.WriteLine($"{userInput} in Rever order: {string.Join("", words)}");
