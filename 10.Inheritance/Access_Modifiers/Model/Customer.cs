using System;

namespace Access_Mofieiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //    Console.WriteLine("Promoted to Level-1");
            //else
            //    Console.WriteLine("Promoted to Level-2");
            Console.WriteLine("Promote Logic Changed.");
        }

        /**
         * If some point Promoting Customer logic has changed
         * Then we need to change each spot where we use this code
         * 
         * ** Better to use Class Business Logic Inside class and a Wrapping function
         */
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}

        //private int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}