using System;

namespace Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            useParams();
            usePoints();

            /**
             * * use "out" keyword
             */
            int vala = 0;
            int.Parse("440", val); // val will be the result of the Parse method
            Console.WriteLine(val);
        }

        static void useParams()
        {
            var addition = new Addiction();
            addition.Add(1, 2, 3, 77, 80);
            addition.Add(new int[] { 1, 2, 3, 77, 80 });
        }

        static void usePoints()
        {
            try
            {
                var point = new Point(10, 12);

                point.Move(new Point(4, 5));  // Calls Move 2
                Console.WriteLine($"{point.X}, {point.Y}");

                point.Move();  // Calls Move 2
                Console.WriteLine($"{point.X}, {point.Y}");

                point.Move(15, new Point(11, 22));  // Calls Move 3
                Console.WriteLine($"{point.Speed}, {point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error occurred.");
            }

        }
    }
}
