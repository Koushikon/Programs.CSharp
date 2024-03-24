using Fields_Properties.Models;

namespace Fields_Properties;

public class Program
{
    static void Main()
    {
        // Example of field and properties
        Sample sample = new();

        /***
         * * Field
         * * Output =>
         * * Name: Lufi
         * * Name: Zoro
         * * Name: Sanji
         */
        Person person = new();
        person.UpdateName();

        // Accessing a static fielld without instantiating the class
        Car.PurchaseAge = 14;
        Console.WriteLine("This car was purchased: " + Car.PurchaseAge + " year ago.");

        // use of readonly keyword
        FootBall footBall = new();

        // use of required keyword
        Train train = new() { Id = 7 };
        Console.WriteLine("Id is " + train.Id);

        /***
         * * Properties in C#
         */
        Configuration configuration = new();
        configuration.SecretKey = "JKLMNO";
        Console.WriteLine("Secret Key: " + configuration.MaskedSecretKey);

        Rectangle rectangle = new() { Height = 10, Width = 15 };
        // rectangle.Height = 17.5; // We'll get an error
        Console.WriteLine($"Height: {rectangle.Height} - Width: {rectangle.Width}");

        // static properties
        Console.WriteLine($"Radius: {Circle.Radius}");
        Circle.Radius = 2.7;
        Console.WriteLine($"Radius: {Circle.Radius}");

        // Setting a property logic backed by a private field
        Box box = new() { Width = 5.2 };
        // box.Width = 5.7; // gets an error we cannot assign property with init like this
        // box.Width = -4.5; // Gets an Argument exception error
        Console.WriteLine("Box Width: " + box.Width);

        Console.WriteLine("End of World.");
    }
}