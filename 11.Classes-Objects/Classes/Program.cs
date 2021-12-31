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
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Introduce();

            // Creating an object of the class Calculator
            // Instance of the class Calculator
            Calculator calculator = new Calculator();
            int result = calculator.Add(9, 3);
            Console.WriteLine(result);
        }
    }
}
