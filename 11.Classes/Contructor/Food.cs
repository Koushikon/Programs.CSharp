using System;

namespace Contructor
{
    public class Food
    {
        public int id;
        public string name;

        // There is no default constructor in this class

        // Its 1 argument constructor
        public Food(int p_id)
        {
            this.id = p_id;
            this.name = "Payes";
        }

        // Its 2 argument constructor
        public Food(int p_id, string p_name)
        {
            this.id = p_id;
            this.name = p_name;
        }
    }
}