using Matrix.Providers;

namespace Matrix.Patterns;

public static class TapHelper
{
	public async static Task FetchAndPrintUser(int userId)
	{
		TapUserProvider provider = new();

		var user = await provider.GetUserAsync(userId);

		Console.WriteLine($"ID : {user.Id}, Name : {user.Name}");
	}
}
