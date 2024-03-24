using Challenge_1.Interfaces;

namespace Challenge_1.Models;

public class EncodeVideoActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("\tActivity: Video encoded sucessfully.");
    }
}