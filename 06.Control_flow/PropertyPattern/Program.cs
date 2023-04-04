using System.Net;

/**
 * Title: Extended Property Pattern
 * Description: C# Property Pattern Code
 */

namespace PropertyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var data = new PersonModel();

            /**
             * * Before C# Version 10
             */
            if (data is { FirstName: "Tim", Address: { City: "Kolkata" } })
            {
                Console.WriteLine($"Before C# Version 10");
            }

            /**
             * * After C# Version 10
             */
            if (data is { FirstName: "Tim", Address.City: "Kolkata", Address.ZipCode: "700001" })
            {
                Console.WriteLine($"After C# Version 10");
            }
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; } = "Tim";
        public string LastName { get; set; } = "Corey";
        public AddressModel Address { get; set; } = new AddressModel();
    }

    public class AddressModel
    {
        public string City { get; set; } = "Kolkata";
        public string State { get; set; } = "West Bengal";
        public string ZipCode { get; set; } = "700001";
    }
}