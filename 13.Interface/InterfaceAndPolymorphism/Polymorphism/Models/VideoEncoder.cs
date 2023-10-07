using Polymorphism.Interfaces;

namespace Polymorphism.Models;

public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannels;

    public VideoEncoder()
    {
        _notificationChannels = new List<INotificationChannel>();
    }

    public void RegisterNotificationChannel(INotificationChannel channel)
    {
        _notificationChannels.Add(channel);
    }

    /***
     * As we can see with Interface we can have polymorphic behaviour.
     */
    public void Encode(Video video)
    {
        // Video encoding logic
        // ...

        foreach (var channel in _notificationChannels)
        {
            channel.Send(new Message());
        }
    }
}