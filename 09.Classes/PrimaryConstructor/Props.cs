namespace PrimaryConstructor;

public class PropsBefore
{
    public string FirstName { get; }
    public string LastName { get; }

    public PropsBefore(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}


public class PropsAfter(string firstName, string lastName)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;

    public void Test()
    {
        /***
         * We can use the Primary Constructor parameters directly here
         * But, we're capturing the value in our FirstName property
         * 
         * If use use the Primary Constructor parameter name anyway it will show a warning message:
         * Parameter 'string firstName' is captured into the state of the enclosing type and its value is also used to initialize a field, property, or event.
         * 
         * Better to use the property name everywhere
         */
        // Console.WriteLine(firstName);    // Using Parameter name

        Console.WriteLine(FirstName);   // Using Property name
    }
}