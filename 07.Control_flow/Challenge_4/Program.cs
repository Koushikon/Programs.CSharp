using System;

/**
 * * 4 Chances to Guess the Number 
 */

static int takeInput(string word)
{
    Console.Write($"Enter {word} number: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

static bool guessing_game(int lnum)
{
    int CountDown = 0;
    const int Guess = 4;

    while (CountDown < Guess)
    {
        int trying = takeInput("a");
        if (lnum == trying)
        {
            return true;
        }
        CountDown += 1;
    }
    return false;
}

int LuckyNumber = takeInput("Secret");
Console.WriteLine((guessing_game(LuckyNumber)) ? "🏆 You Won" : "😜 You Lose");