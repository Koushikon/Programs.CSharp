using Challenge_1.Interfaces;

namespace Challenge_1.Models;

public class UpdateVideoRecordActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("\tActivity: Update the video status to Processing.");
    }
}