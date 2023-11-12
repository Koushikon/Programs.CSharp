using Matrix.Models;
using Matrix.Services;

namespace Matrix.Providers;

public class TapUserProvider
{
	private readonly UserService _userService;

	public TapUserProvider()
	{
		_userService = new UserService();
	}

	public User GetUser(int userId) => _userService.GetUserData(userId);

	public Task<User> GetUserAsync(int userId)
	{
		return Task.Run(() => GetUser(userId));
	}
}