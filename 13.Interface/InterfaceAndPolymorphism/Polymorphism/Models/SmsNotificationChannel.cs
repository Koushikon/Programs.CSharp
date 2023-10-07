using Polymorphism.Interfaces;

namespace Polymorphism.Models;

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending sms...");
    }
}