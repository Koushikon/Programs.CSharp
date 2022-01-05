using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // With Console.WriteLine() we can write text to the console.
            Console.WriteLine("What is your name?");

            // ReadLine() reads a line of input from the console.
            var name = Console.ReadLine();

            // DateTime.Now returns the current date and time.
            var currentDate = DateTime.Now;

            // Using $ we can write text with variables.
            // Environment.NewLine is a new line character.
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

            // Console.Write() writes a string to the console But it does not add a new line.
            Console.Write($"{Environment.NewLine}Press any key to exit...");

            // ReadKey() reads a single key from the console.
            Console.ReadKey(true);
        }
    }
}