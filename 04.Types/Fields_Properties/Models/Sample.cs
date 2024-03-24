
namespace Fields_Properties.Models;

public class Sample
{

    // Creating a field of type int and with private accessor
    private int _age;

    // Creating a Age Property that uses the _age field as the back field
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}