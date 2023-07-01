
namespace Record_Type;

public class Program
{
    public static void Main()
    {
        var member1 = new Member
        {
            Id = 1,
            FirstName = "ANik",
            MiddleName = "Kr.",    // added new property
            LastName = "BSk",
            Address = "Jupitar"
        };

        var member2 = new Member
        {
            Id = member1.Id,
            FirstName = member1.FirstName,
            MiddleName = member1.MiddleName,    // added new property
            LastName = member1.LastName,
            Address = "Mars"
        };

        Console.WriteLine($"\nId: {member2.Id}\n First Name: {member2.FirstName}\n Middle Name: {member2.MiddleName}\n Last Name: {member2.LastName}\n Address: {member2.Address}");

        var person1 = new Person
        {
            Id = 1,
            FirstName = "ANik",
            LastName = "BSk",
            Address = "Jupitar"
        };

        // Not using With expression
        var person2 = new Person
        {
            Id = person1.Id,
            FirstName = person1.FirstName,
            LastName = person1.LastName,
            Address = "Mars"
        };

        Console.WriteLine($"\nId: {person2.Id}\n First Name: {person2.FirstName}\n Last Name: {person2.LastName}\n Address: {person2.Address}");


        // Using With expression
        var person3 = person2 with { Address = "Haydrabad" };

        Console.WriteLine($"\nId: {person3.Id}\n First Name: {person3.FirstName}\n Last Name: {person3.LastName}\n Address: {person3.Address}");
    }
}

public class Member
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? MiddleName { get; init; }    // added new property
    public string? LastName { get; init; }
    public string? Address { get; init; }
}

public record Person
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Address { get; init; }
}