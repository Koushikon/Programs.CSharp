using System;

namespace Inheritance
{
    public class My_Child : My_Parent
    {
        string myname = "Koushik";

        public void Parents_Name()
        {
            Console.WriteLine("Father name is: {0}\nMother name is: {1}", father, mother);
        }

        public void Child_Name()
        {
            Console.WriteLine("My name is: {0}", myname);
        }
    }
}