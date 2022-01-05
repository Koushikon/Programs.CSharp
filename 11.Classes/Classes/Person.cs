using System;

namespace Classes
{
    // Creating class at the namespace level
    public class Person{
        public String FirstName;
        public String LastName;

        public void Introduce(){
            Console.WriteLine("It's me " + FirstName + " " + LastName);
        }
    }
}