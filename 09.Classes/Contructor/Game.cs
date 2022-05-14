using System.Collections.Generic;

namespace Contructor
{
    public class Game
    {
        public int id;
        public string name;

        /**
         * * Best Practice:
         * Whenever we have class that have List of Objects of any type
         * Allways initialize it with an Empty List
         */
        public List<Order> orders;


        /**
         * * With Contructor "Chaining":
         * * We're delegating the work to the other constructor
         * * without writing the same code twice like "order" List
         
         * * Its hard to understand and maintain So, Use it when needed
         */

        // Its Default constructor
        public Game()
        {
            // Without this if we Add an Order to the List
            // It will throw an error - System.NullReferenceException
            orders = new List<Order>();
        }

        // Its 1 argument constructor
        public Game(int p_id)
            : this()        // Its called Constructor Chaining and Calling Default constrctor
        {
            this.id = p_id;
            this.name = "H.A.L.O.";
        }

        // Its 2 argument constructor
        public Game(int p_id, string p_name)
            : this(p_id)    // Calling Default constrctor
        {
            this.id = p_id;
            this.name = p_name;
        }
    }
}