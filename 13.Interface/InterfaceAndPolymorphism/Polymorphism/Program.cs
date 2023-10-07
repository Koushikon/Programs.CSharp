using Polymorphism.Models;

namespace Polymorphism;

public class Program
{
    static void Main(string[] args)
    {
        var encoder = new VideoEncoder();

        /**
         * Now if want another notification technique we just need to implement the INotificationChannel interface.
         * 
         * That way we can register that class with RegisterNotificationChannel method
         * Without changing any code of VideoEncoder class.
         */

        // Adding SMS Notification channel
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        // Adding Mail Notification channel
        encoder.RegisterNotificationChannel(new MailNotificationChannel());

        encoder.Encode(new Video());
    }
}