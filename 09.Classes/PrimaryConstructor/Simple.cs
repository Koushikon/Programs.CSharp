namespace PrimaryConstructor;

/***
 * With C# 11 and Previous
 */
public class SimpleBefore
{
    private string _firstName;
    private readonly string _lastName;

    public SimpleBefore(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void FullName()
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }
}

public record SimpleRecord(string FirstName, string LastName);

/***
 * Now With C# 12
 * Primary Constructor makes the Code more compact
 */
public class SimpleAfter(string firstName, string lastName)
{
    /***
     * Primary Constructor does not support Immutable parameters
     * 
     * Also Parameters in Primary Constructor are available througout the class
     * But above parameters in Primary Constructor not being a readonly field.
     * We can change the values of parameters to something else inside the class
     * 
     * But in order to use it like private readonly field we can create a
     * private readonly field with the same name as Primary Constructor parameter
     * Then we cannot change the value of that parameter
     */
    private readonly string lastName = lastName;

    public void FullName()
    {
        // we cannot write the values like this:
        // this.lastName = "Nine";

        // Can be changed if we don't set it readonly
        // lastName = "One";

        Console.WriteLine(firstName + " " + lastName);
    }

    /**
     * We can use other Constructors too
     * But in this case we must have initializer for our Primary Constructor
     */

    public SimpleAfter() : this ("", "")
    { }
}