using System;

int bill = 50;
string name;

Console.WriteLine("Write your name? ");
name = Console.ReadLine();

Console.WriteLine("{0} earns {1} cents.", name, bill);
// Or, This way:
Console.WriteLine($"{name} earns {bill} cents.");

Console.Write("Press any key...");
Console.ReadKey(true);