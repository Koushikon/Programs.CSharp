using Challenge_1.Interfaces;

namespace Challenge_1.Models;

public class UploadVideoActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("\tActivity: Video uploaded sucessfully.");
    }
}