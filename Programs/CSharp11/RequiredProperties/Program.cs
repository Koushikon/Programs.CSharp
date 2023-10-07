using RequiredProperties.Models;

namespace RequiredProperties;

internal class Program
{
    static void Main(string[] args)
    {
        // We want to always provide the FirstName and LastName
        // With required modifier this initialization works fine
        PersonModel person1 = new()
        {
            FirstName = "Koushik",
            LastName = "Saha"
        };

        /***
         * But with required modifier if we initialize the object through constructor
         * 
         * We're still getting error:
         * Required member 'PersonModel.LastName' must be set in the object initializer or attribute constructor.
         * 
         * But it didn't understand we are passing all the values.
         * To Fix this: we can use [SetsRequiredMembers] attribute on the class constructor.
         * Then we'll initialize it both ways and don't get any error.
         */
        PersonModel person2 = new("Koushik", "Saha");
        PersonModel person3 = new();
    }
}