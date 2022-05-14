using System;
using System.Text;

/**
 * * Question: Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
 */

StringBuilder PascalCase(string[] words)
{
    StringBuilder stb1 = new StringBuilder();
    foreach (string w in words)
    {
        stb1.Append(w.ToUpper().Substring(0, 1));
        stb1.Append(w.ToLower().Substring(1));
    }

    return stb1;
}

var words = Console.ReadLine().Split(' ');

if (string.IsNullOrWhiteSpace(words[0]))
    System.Environment.Exit(1);

string res = PascalCase(words).ToString();
Console.WriteLine(res);