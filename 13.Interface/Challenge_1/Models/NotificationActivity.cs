using Challenge_1.Interfaces;

namespace Challenge_1.Models;

public class NotificationActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("\tActivity: Sended video started processing notification sucessfully.");
    }
}