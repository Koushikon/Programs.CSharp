namespace Matrix.Models;

public class SharedData
{
    public const int InitialCapacity = 100;

    public static Dictionary<int, User> userDictionary = new(5)
    {
        { 1, new User() { Id = 1, FirstName = "Liton", LastName = "Das" } },
        { 2, new User() { Id = 2, FirstName = "Raju", LastName = "Sarkar" } },
        { 3, new User() { Id = 3, FirstName = "Sourav", LastName = "Das" } },
        { 4, new User() { Id = 4, FirstName = "Anirban", LastName = "Panja" } },
        { 5, new User() { Id = 5, FirstName = "Dinesh", LastName = "Das" } }
    };

    public static List<User> UserList => new(3)
    {
        new User() { Id = 1, FirstName = "Liton", LastName = "Das" },
        new User() { Id = 2, FirstName = "Raju", LastName = "Sarkar" },
        new User() { Id = 3, FirstName = "Sourav", LastName = "Das" }
    };
}
