using System;
using Model;

namespace Model
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
            // throw new System.NotImplementedException("Drawing a circle.");
        }
    }
}