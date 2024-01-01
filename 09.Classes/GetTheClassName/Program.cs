using System.Reflection;

namespace GetTheClassName;

/***
 * * Get the Class or Clss Property name as a String
 */


internal class Program
{
    static void Main()
    {
        var car = new Car();
        Console.WriteLine(car.GetClassName());

        // We can also directly call GetType().Name on the object to retrieve the class name from an external context. 
        Console.WriteLine(car.GetType().Name);

        // The typeof operator fetches a System.Type instance, representing a type at compile time.
        Console.WriteLine(typeof(Car).Name);

        // The nameof operator gives us the name of a type or a member as a string at compile time.
        Console.WriteLine(nameof(Car));
        Console.WriteLine(nameof(Car.FirstName));

        // Using Reflection to get the class name
        Console.WriteLine(car.GetClassNameUsingReflection());
    }
}


public class Car
{
    public string? FirstName { get; set; }

    public string GetClassName()
    {
        // GetType() method is invoked on an instance of an object.
        return GetType().Name;
    }

    public string GetClassNameUsingReflection()
    {
        // MethodBase.GetCurrentMethod() method, which is a part of the System.Reflection namespace.
        // This method fetches a MethodBase object representing the currently executing method, and we can derive the class name from it:
        return MethodBase.GetCurrentMethod()?.DeclaringType?.Name ?? string.Empty;
    }
}