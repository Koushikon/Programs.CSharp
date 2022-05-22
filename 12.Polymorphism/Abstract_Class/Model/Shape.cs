using System;

namespace Model
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        // Methods
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into Clipboard.");
        }
        public void Select()
        {
            Console.WriteLine("Select any shape.");
        }
    }
}