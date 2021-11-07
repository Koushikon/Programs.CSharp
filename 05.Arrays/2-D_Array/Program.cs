using System;

/*************
 * C# 2-D Array declarations
*************/

int[,] a = new int[3, 3] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

Console.WriteLine("\nBefore changing:");
Console.WriteLine($"The 2-D value of a Row 1 Column 1 is: {a[0, 0]}");
Console.WriteLine($"The 2-D value of a Row 2 Column 2 is: {a[1, 1]}");
Console.WriteLine($"The 2-D value of a Row 3 Column 3 is: {a[2, 2]}");

string userInput;

// Taking an input and changing a Row 2 Column 2's value
Console.Write("Enter the value for a Row 2 Column 2 is:");
userInput =  Console.ReadLine();
a[1, 1] = Convert.ToInt32(userInput);

// Taking an input and changing a Row 3 Column 3's value
Console.Write("Enter the value for a Row 3 Column 3 is:");
userInput =  Console.ReadLine();
a[2, 2] = Convert.ToInt32(userInput);

Console.WriteLine("\nAfter changing:");
Console.WriteLine($"The 2-D value of a Row 1 Column 1 is: {a[0, 0]}");
Console.WriteLine($"The 2-D value of a Row 2 Column 2 is: {a[1, 1]}");
Console.WriteLine($"The 2-D value of a Row 3 Column 3 is: {a[2, 2]}");


