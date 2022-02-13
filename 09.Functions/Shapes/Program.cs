using System;

/**
 * * Area of Rectangle: l * w
 * * Area of Circle: π r^2
 */

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Are of Rectangle is {area_of_rectangle(7, 4)}");
            Console.WriteLine($"Are of Circle is {area_of_circle(4.2)}");
        }

        static int area_of_rectangle(int w, int l)
        {
            return w * l;
        }

        static double area_of_circle(double r)
        {
            double pi = 3.14159;
            return pi * r * r;
        }
    }
}
