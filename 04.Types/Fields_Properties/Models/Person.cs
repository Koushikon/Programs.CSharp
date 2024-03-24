
namespace Fields_Properties.Models;

/***
 * * Here, We Set the of _name at the time of declaration.
 * * Then we update the value in the constructor.
 * * Finaly we have additional method UpdateName that updates the value.
 * *
 */

public class Person
{
    private string _name = "Lufi";

    public Person()
    {
        Console.WriteLine("Name: " + _name);
        _name = "Zoro";
    }

    public void UpdateName()
    {
        Console.WriteLine("Name: " + _name);
        _name = "Sanji";
        Console.WriteLine("Name: " + _name);
    }
}