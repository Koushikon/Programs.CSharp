namespace Matrix.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}