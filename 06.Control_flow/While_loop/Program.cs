using System;

/*************
 * C# While loop
*************/

// Example -1
int num = 0;
string userInput;

Console.Write("Enter a positive number  -Start the countdown: ");
userInput = Console.ReadLine();
num = Convert.ToInt32(userInput);

while (num <= 10)
{
    Console.Write($"{num++} ");
}

Console.WriteLine();


// Example -2
int num2 = 0;
Console.Write("Enter a positive number to count upto: ");
userInput = Console.ReadLine();
num2 = Convert.ToInt32(userInput);

int i = 1;
while (num2 >= i)
{
    Console.Write($"{i++} ");
}

Console.WriteLine();


// Example -3
int number1 = 0;
Console.Write("Enter an number less than 100: ");
userInput = Console.ReadLine();
number1 = Convert.ToInt32(userInput);

while (number1 >= 100) // or (!(number >= 100))
{
    Console.Write("Enter an number less than 100: ");
    userInput = Console.ReadLine();
    number1 = Convert.ToInt32(userInput);
}
Console.WriteLine("Out of program.");


// Example -4 using boolean flag.
bool done = false;
int number2 = 0;
while (!done)
{
    Console.Write("Enter an number between 1 and 5: ");
    userInput = Console.ReadLine();
    number2 = Convert.ToInt32(userInput);

    // Check the input
    if (number2 <= 1 || number2 >= 5)
    {
        Console.WriteLine("Out of range, Try again.");
        continue;
    }
    else
    {
        Console.WriteLine("Out of program.");
        done = true;
    }
}


// Example -5 Above program more simplified way.
int number3 = 0;
while (true)
{
    Console.Write("Enter an number between 1 and 5: ");
    userInput = Console.ReadLine();
    number3 = Convert.ToInt32(userInput);

    // Check the input
    if (number3 >= 1 && number3 <= 5)
    {
        Console.WriteLine("Out of program.");
        break;
    }
    else
    {
        Console.WriteLine("Out of range, Try again.");
        continue;
    }
}
