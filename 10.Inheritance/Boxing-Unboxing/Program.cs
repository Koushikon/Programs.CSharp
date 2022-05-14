using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * * Here we don't know what type we're gonna Add
             * * This type of list takes value types as object
             * * And Boxing and Unboxing happens
             */
            var list = new ArrayList();
            list.Add(1); // Value Type - Boxing and Unboxing happens
            list.Add("Jin"); // Reference Type
            list.Add(DateTime.Today); // struct Value Type - Boxing and Unboxing happens

            var Number = (int)list[0];
            // var Number = (int)list[1]; // Error occurred

            /**
             * * Here we know that int type we're gonna Add
             * * This type of list takes the type same as when it was created
             * * No Boxing or Unboxing happens.
             * * We get type safety
             */
            var list1 = new List<int>();
            list1.Add(1); // Int type

            // Or,
            var list2 = new List<char>();
            list2.Add('K'); // Char type
        }
    }
}
