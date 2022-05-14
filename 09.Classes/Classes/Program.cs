using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        // static because this function is going to be the only entry point of our program
        static void Main(string[] args)
        {
            // Creating an object of the class Person
            // Instance of the class Person
            Person p1 = new Person();
            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.age = 17;
            p1.Introduce();
            Console.WriteLine("P1's age is {0}", p1.get_age());

            // Creating an object of the class Calculator
            // Instance of the class Calculator
            Calculator c1 = new Calculator();
            int result1 = c1.Add(9, 3);
            Console.WriteLine("Sum is {0}", result1);

            double result2 = c1.Add(9.335, 3.025);
            Console.WriteLine("Sum is {0}", result2);
        }
    }
}
