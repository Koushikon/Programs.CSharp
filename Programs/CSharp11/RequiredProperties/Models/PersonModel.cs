using System.Diagnostics.CodeAnalysis;

namespace RequiredProperties.Models;

internal class PersonModel
{
    /***
     * With required we have to provide the FirstName and LastName when creating class object
     */
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }

    [SetsRequiredMembers]
    public PersonModel()
    {
        FirstName = "Test1";
        LastName = "Test2";
    }

    [SetsRequiredMembers]
    public PersonModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}