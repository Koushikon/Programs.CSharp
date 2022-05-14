using System;

/**
 * * Question: Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
 */

string uInput = Console.ReadLine();

try
{
    DateTime dt1 = Convert.ToDateTime(uInput);
    uInput = dt1.ToShortTimeString();
}
catch
{
    uInput = "";
}

Console.WriteLine((!string.IsNullOrWhiteSpace(uInput)) ? $"Ok {uInput}" : "Invalid time");