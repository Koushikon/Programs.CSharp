// Using Implicit Usings
// File location: obj/Debug/net6.0/<some_name>.GlobalUsings.g.cs

Console.WriteLine("ImplicitUsings || Global Usings with file \"global.usings.cs\"");

User user = new User()
{
    Id = 1,
    Name = "Test",
    Email = "Test@gmail.com",
    Age = 17,
};

Console.WriteLine($"User: Name= {user.Name}, Email= {user.Email}, Age= {user.Age}");