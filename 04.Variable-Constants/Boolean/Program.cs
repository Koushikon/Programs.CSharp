using System;

/*************
 * boolean type
*************/

bool game_over = false;
Console.WriteLine($"Game result was- {game_over}");

bool red = true, green = false;

if (red != green)
    Console.WriteLine("Go through!!");
else
    Console.WriteLine("Stop.");

Console.WriteLine(green ? "Yes, its on" : "No, its not on");

Console.WriteLine("Green light: {0} and it is \"{1}\" type", green, green.GetType());
