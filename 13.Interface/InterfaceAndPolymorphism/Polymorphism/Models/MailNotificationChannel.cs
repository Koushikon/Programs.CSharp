using Polymorphism.Interfaces;

namespace Polymorphism.Models;

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending mail...");
    }
}