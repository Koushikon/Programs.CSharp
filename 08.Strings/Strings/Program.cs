using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * * Uppercase String is a String classes object
             * * If we use Uppercase String we need to import the System namespace
             * 
             * * lowercase string mapped to the String class
             */

            String word1 = "Jimmy";
            string word2 = "World";
            Console.WriteLine("Bring back my " + word1 + ' ' + word2);

            string word3 = "Hello" + word1 + " " + word2;
            Console.WriteLine(word3);

            /**
             * * Using the string format
             */

            word2 = "Earth";
            string word4 = string.Format("{0} {1}", word1, word2);
            Console.WriteLine(word4);

            /**
             * * Using string Join
             */

            var numbers = new int[5] {7, 6, 3, 3, 5};
            string list = string.Join(" ", numbers);
            Console.WriteLine(list);

            /**
             * * Using string index
             * * We cannot change the value of the string with index
             */
            
            word4 = "HannahMontana"; // Start from 0
            Console.WriteLine(word4[2]);
            Console.WriteLine(word4[word4.Length - 1]);

            /**
             * * Using Verbatim String with
             * * @
             * * Its much cleaner way to write the string
             */

            string path1 = "c:\\windows\\system32\\temp\\file.txt";
            Console.WriteLine(path1);

            string path2 = "Its Temporary file path First:\n\tc:\\windows\\system32\\temp\\file.txt";
            Console.WriteLine(path2);
            
            string path3 = @"Its Temporary file path Second:
                c:\windows\system32\temp\file.txt";
            Console.WriteLine(path3);
        }
    }
}
