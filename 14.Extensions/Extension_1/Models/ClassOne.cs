
namespace Extension_1.Models;

public class ClassOne
{
    public string Message { get; set; } = string.Empty;

    public void Display()
    {
        Console.WriteLine("I'm in display.");
    }

    public void Print()
    {
        Console.WriteLine("I'm in print.");
    }
}