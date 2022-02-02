using System;

/*************
 * C# Array Taking Input and Show them
*************/

// 1_D Array
int[] t_case = new int[5];

Console.WriteLine("\nAll Test input:");
t_case[0] = int.Parse(Console.ReadLine());
t_case[1] = int.Parse(Console.ReadLine());
t_case[2] = int.Parse(Console.ReadLine());
t_case[3] = int.Parse(Console.ReadLine());
t_case[4] = int.Parse(Console.ReadLine());

Console.WriteLine($"The 1st Test: {t_case[0]} \nThe 2nd Test: {t_case[1]}\nThe 3rd Test: {t_case[2]}\nThe 4th Test: {t_case[3]}\nThe 5th Test: {t_case[4]}");

// Boolean Array in C#
var flags = new bool[4] { true, false, true, false };
Console.WriteLine(string.Join(' ', flags));

// 2_D Integer Array
int[,] a = new int[3, 3] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

Console.Write("Enter the value for a Row 2 Column 2 is:");
a[1, 1] = int.Parse(Console.ReadLine());

Console.Write("Enter the value for a Row 3 Column 3 is:");
a[2, 2] = int.Parse(Console.ReadLine());

Console.WriteLine("\nAfter changing:");
Console.WriteLine($"The 2-D value of a Row 1 Column 1 is: {a[0, 0]}");
Console.WriteLine($"The 2-D value of a Row 2 Column 2 is: {a[1, 1]}");
Console.WriteLine($"The 2-D value of a Row 3 Column 3 is: {a[2, 2]}");