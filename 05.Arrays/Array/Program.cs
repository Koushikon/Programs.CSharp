using System;

/*************
 * C# Array declarations
*************/

char[] vowels = new char[5] {'a','e','i','o','u'};
Console.WriteLine($"The second vowels: {vowels[1]}");
Console.WriteLine($"The fourth vowels: {vowels[4]}");

// Runtime error cause array out of bounds
// It should be 0 to 4
// vowels[5] = userInput;

double[] hi_temps = new double[] {90.1, 67.3, 33.1, 42.8};
Console.WriteLine($"\nThe second temperature: {hi_temps[1]}");
Console.WriteLine($"The third temperature: {hi_temps[2]}");

hi_temps[1] = 105.2;
Console.WriteLine($"The updated second temperature: {hi_temps[1]}");

// By default all the elements in the array are initialized to 0.
int[] test_case = new int[5];
Console.WriteLine("\nTest case of 2 is {0} , 3 is {1} and 4 is {2}", test_case[2], test_case[3], test_case[4]);

int[] test_case_2 = {59, -60, 75, 32, -5};

Console.WriteLine("\nThe first Test_case: {0}\nThe first Test_case: {1}\nThe first Test_case: {2}\nThe first Test_case: {3}\nThe first Test_case: {4}", test_case_2[0], test_case_2[1], test_case_2[2], test_case_2[3], test_case_2[4]);

string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

Console.Write($"\n{weekDays2[0]}");
Console.Write($"\t{weekDays2[1]}");
Console.Write($"\t{weekDays2[2]}");
Console.Write($"\t{weekDays2[3]}");
Console.Write($"\t{weekDays2[4]}");
Console.Write($"\t{weekDays2[5]}");
Console.WriteLine($"\t{weekDays2[6]}");

// cout << "\nAll Test_cases input: ";
// cin >> test_case[0] >> test_case[1] >> test_case[2] >> test_case[3] >> test_case[4];

// cout << "The first Test_case: " << test_case[0] << endl
//     << "The first Test_case: " << test_case[1] << endl
//     << "The first Test_case: " << test_case[2] << endl
//     << "The first Test_case: " << test_case[3] << endl
//     << "The first Test_case: " << test_case[4] << endl;

// cout << "\nNotice what if we just type the name: " << test_case << endl;
// The test_case value diplaying on the output is the actual memory location of this array.
