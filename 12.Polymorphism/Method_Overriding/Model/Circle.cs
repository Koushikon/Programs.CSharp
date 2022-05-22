using System;

namespace Model
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a circle.");
        }
    }
}
