using Matrix.Models;

namespace Matrix.Services;

public class UserService
{
	private readonly List<User> _users = new()
	{
		new User { Id = 101, Name = "Selim" },
		new User { Id = 102, Name = "Sam" }
	};

	public User GetUserData(int userId)
	{
		// Long-running operation
		return _users.FirstOrDefault(u => u.Id == userId) ?? new User();
	}
}