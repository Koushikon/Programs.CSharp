using System;

string userInput = "";

int room_width = 0;

Console.Write("Enter the Room width: ");
userInput = Console.ReadLine();
room_width = Convert.ToInt32(userInput);

int room_height = 0;

Console.Write("Enter the Room height: ");
userInput = Console.ReadLine();
room_height = Convert.ToInt32(userInput);

Console.WriteLine($"The area of the room is {room_width * room_height} squire feet.");
