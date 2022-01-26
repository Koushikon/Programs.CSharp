using System;

/**
 * * Write a Program like Facebooks Like System
 * * If one person likes then [abc] likes your Post.
 * * If two person likes then [abc], [def] likes your Post.
 * * If More than two people likes then [abc], [def] and [no_of_people] others likes your Post.
 */
int num = 0;
string[] person = new string[2];
string userInput = string.Empty;

do
{
    Console.Write("Enter the User Name: ");
    userInput = Console.ReadLine();

    if (num < 2)
        person[num] = userInput;
    if (userInput != "")
        num++;
} while (userInput != "");

// if (num < 1)
//     Console.Write("No One");
// else if (num == 1)
//     Console.Write($"{person[0]}");
// else if (num == 2)
//     Console.Write($"{person[0]}, {person[1]}");
// else
//     Console.Write($"{person[0]}, {person[1]} and {num - 2} others");
// Console.WriteLine(" likes your post.");

string res = (
        (num < 1) ? "No One" :
        (num == 1) ? $"{person[0]}" :
        (num == 2) ? $"{person[0]}, {person[1]}" :
        $"{person[0]}, {person[1]} and {num - 2} others"
    ) + " likes your post.";

Console.WriteLine(res);