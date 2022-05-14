using System;
using System.Collections.Generic;

namespace Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * * There's no constrctor is Customer class
             * * C# automatically provides a default constructor
             */
            var cs = new Customer();
            Console.WriteLine(cs.id);   // Default value of 0
            Console.WriteLine(cs.name); // Default value of null


            /**
             * * Food class does not have a default constructor
             * * So we need to provide parameter according to what we have in the class
             */
            // var fd = new Food();     // Its not gonna work
            var fd = new Food(17);
            Console.WriteLine(fd.id);   // Default value of 11
            Console.WriteLine(fd.name); // Default value of "Payes"

            /**
             * * Game class have a default constructor aand other too
             */
            var gm = new Game(); // Now it has 3 Overloaded constructors
            Console.WriteLine(gm.id);   // Default value of 10
            Console.WriteLine(gm.name); // Default value of "H.A.L.O."

            /**
             * * Order class has no provided constructor
             * * We are initializing the Game class "orders" List with an Empty List

             * * Contructor Usefullness:
             * * Also we're initializing it at the time of "gm" object creation
             */
            var or = new Order();
            // So if we don't initialize it with an empty list
            // It will throw an error - System.NullReferenceException
            gm.orders.Add(or);

            /**
             * * OR, we can directly initialize it from here
             * * Its a Hack, But we should not do this because
             * * Best Practice To:
             * * Class member initizlization should happen inside its own class
             */
            gm.orders = new List<Order>();
            gm.orders.Add(or);
        }
    }
}
