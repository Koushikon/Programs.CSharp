using System;
public class Point
{
    public int X, Y;
    public int Speed;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x = 0, int y = 0)
    {    // ...1
        this.X = x;
        this.Y = y;
    }

    public void Move(Point Location)
    {  // ...2
        if (Location == null)
            throw new ArgumentNullException("Location", "Has null value.");

        Move(Location.X, Location.Y);
    }

    public void Move(int speed, Point Location)
    {   // ...3
        Move(Location.X, Location.Y);
        this.Speed = speed;
    }
}