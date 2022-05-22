using System;
using System.Collections.Generic;
using Model;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());   // At the runtime Circle Draw method will invoke
            shapes.Add(new Rectangle());// At the runtime Rectangle Draw method will invoke
            //shapes.Add(new Triangle());


            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            // This is the sign of a loosely coupled Application
        }
    }
}
