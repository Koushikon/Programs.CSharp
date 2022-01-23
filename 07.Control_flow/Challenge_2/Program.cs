using System;

/**
 * * Sum of Numbers
 */

int sum = 0;
int number = 0;
string userInput = "";

do
{
    Console.Write("Write a number: ");
    userInput = Console.ReadLine();

    try
    {
        int.TryParse(userInput, out number);
    }
    catch (System.FormatException)
    {
        continue;
    }
    finally
    {
        sum += number;
    }
} while (userInput != "ok");

Console.WriteLine(sum);