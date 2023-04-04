using Library;

namespace Matrix;

internal class Program
{
    static void Main(string[] args)
    {
        var personS = new PersonService();
        
        personS.FirstName = "Anirban";
        personS.LastName = "Panja";

        Console.WriteLine(personS.FullName);
    }
}