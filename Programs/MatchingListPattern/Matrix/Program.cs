using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matrix;

/***
 * Matching List Patterns in C# v11
 * Matching nested values in a single line inside if condition
*/

internal class Program
{
    public static void Main()
    {
        string csv;

        csv = "1,Jimmy,Fallon";
        //csv = "1,Jimmy";
        //csv = "1,Jimmy,Fallon,Asking";
        //csv = "1,Jimmy,Fallon,Asking,Good,Question,is,Also,necessary";
        //csv = "2,Jimmy,Fallon,Asking,Good,Question,is,quite,appropriate";

        Console.WriteLine(csv);
        Console.WriteLine();


        /***
         * Scenario: What if we want to know there three entries in the data otherwise its bad data
         * So, if three data inside the array then give the first value.
         * 
         * Now with this code code we're matching there elements inside that array and only the first one that i want
         * And other two values we do not want and care for.
         */
        csv = "1,Jimmy,Fallon";
        PatternMatching_1(csv);

        /***
         * With this value separated our array has only value
         * So, in this case the pattern is not matched.
         */
        csv = "1,Jimmy";
        PatternMatching_1(csv);

        /***
         * Doing pattern matching on all three elements and capturing them.
         * So, in this case we want the the values and we print them.
         */
        csv = "1,Jimmy,Fallon";
        PatternMatching_2(csv);

        /***
         * Now, its getting 4 elements so it going to show Bad input.
         */
        csv = "1,Jimmy,Fallon,Asking";
        PatternMatching_2(csv);

        /***
         * What if we have mutiple elements that will decied on the runtime
         * In those situation we can use the .. syntax.
         * .. (0 or More Selector) syntax
         */
        csv = "1,Jimmy,Fallon,Asking,Good,Question,is,Also,necessary";
        PatternMatching_3(csv);

        /***
         * With more comma separated data we're fine
         * And its not showing Bad input.
         */
        csv = "2,Jimmy,Fallon,Asking,Good,Question,is,quite,appropriate";
        PatternMatching_3(csv);

        /***
         * What if we have mutiple elements that will decied on the runtime
         * and With those elements we want only first three and last element, How can we do that.
         */
        csv = "2,Jimmy,Fallon,Asking,Good,Question,is,quite,appropriate";
        PatternMatching_4(csv);

        /***
        * Now instead of getting the first and few other elements
        * WE want to match the id with the value
        */
        csv = "2,Jimmy,Fallon,Asking,Good,Question,is,quite,appropriate";
        PatternMatching_5(csv);

        // Then its not matching
        csv = "1,Jimmy,Fallon,Asking,Good,Question,is,Also,necessary";
        PatternMatching_5(csv);

        /***
        * Now the id must be 1 or 2
        */
        csv = "2,Jimmy,Fallon,Asking,Good,Question,is,quite,appropriate";
        PatternMatching_6(csv);

        csv = "1,Jimmy,Fallon,Asking,Good,Question,is,Also,necessary";
        PatternMatching_6(csv);
    }

    static void PatternMatching_1(string data)
    {
        string[] info = data.Split(",");

        if (info is [var id, _, _])
        {
            Console.WriteLine($"Id: {id}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }

    static void PatternMatching_2(string data)
    {
        string[] info = data.Split(",");

        if (info is [var id, var FirstName, var LastName])
        {
            Console.Write($"Id: {id}, ");
            Console.Write($"First Name: {FirstName}, ");
            Console.WriteLine($"Last Name: {LastName}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }

    static void PatternMatching_3(string data)
    {
        string[] info = data.Split(",");

        if (info is [var id, var firstName, var lastName, ..])
        {
            Console.Write($"Id: {id}, ");
            Console.Write($"First Name: {firstName}, ");
            Console.WriteLine($"Last Name: {lastName}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }

    static void PatternMatching_4(string data)
    {
        string[] info = data.Split(",");

        if (info is [var id, var firstName, var lastName, .., var endWord])
        {
            Console.Write($"Id: {id}, ");
            Console.Write($"First Name: {firstName}, ");
            Console.Write($"Last Name: {lastName}, ");
            Console.WriteLine($"End Word: {endWord}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }

    static void PatternMatching_5(string data)
    {
        string[] info = data.Split(",");

        if (info is ["2", var firstName, var lastName, .., var endWord])
        {
            Console.Write($"First Name: {firstName}, ");
            Console.Write($"Last Name: {lastName}, ");
            Console.WriteLine($"End Word: {endWord}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }

    static void PatternMatching_6(string data)
    {
        string[] info = data.Split(",");

        if (info is ["2" or "1", var firstName, var lastName, .., var endWord])
        {
            Console.Write($"First Name: {firstName}, ");
            Console.Write($"Last Name: {lastName}, ");
            Console.WriteLine($"End Word: {endWord}");
        }
        else
        {
            Console.WriteLine("Bad input.");
        }
    }
}