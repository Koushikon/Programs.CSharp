using System;

namespace Class
{
    class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}", to, name);
        }

        public Person Parse_1(string str)
        {
            Person p = new Person();
            p.name = str;
            return p;
        }

        public static Person Parse_2(string str)
        {
            Person p = new Person();
            p.name = str;
            return p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();

            // If we have static we dont have to use it like this
            var p1 = person.Parse_1("Humble");
            p1.Introduce("Tuna");


            var p2 = Person.Parse_2("Justin");
            p2.Introduce("Luna");
        }
    }
}
