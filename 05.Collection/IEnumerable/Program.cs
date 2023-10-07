using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterate through Ienumerable and Show the Data:");
            Display_As_Ineumerable();

            Console.WriteLine("\nIterate through a List and Show the Data:");
            Display_As_List();

            var mySequence = Enumerable.Range(0, 12);

            foreach (int num in mySequence)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        private static void Display_As_Ineumerable()
        {
            var names = new List<string> {
                "sam", "alexia", "simon", "sumanth", "tony", "sam", "amr", "mark", "drew"
            };

            IEnumerable<string> Result = names.Where(w => w.Length > 5);
            names[0] = "benjamin";

            foreach (var name in Result)
            {
                Console.WriteLine(name);
            }
        }

        private static void Display_As_List()
        {
            var names = new List<string> {
            "sam", "alexia", "simon", "sumanth", "tony", "sam", "amr", "mark", "drew"
            };

            List<string> Result = names.Where(w => w.Length > 5).ToList();
            names[0] = "benjamin";

            foreach (var name in Result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
