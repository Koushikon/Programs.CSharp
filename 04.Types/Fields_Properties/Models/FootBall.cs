
namespace Fields_Properties.Models;

public class FootBall
{
    private readonly string _name = "Sunil Chhetri";

    public FootBall()
    {
        Console.WriteLine("Name: " + _name);
        _name = "P.K. Banerjee";
        Console.WriteLine("Name: " + _name);
    }

    public void UpdateName()
    {
        Console.WriteLine("Name: " + _name);
        // A Read-only field cannot be after the constructor exits.
        // _name = "Subrata Pal";
    }
}