using Polymorphism.Models;

namespace Polymorphism.Interfaces;

public interface INotificationChannel
{
    void Send(Message message);
}
