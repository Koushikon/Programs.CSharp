using Matrix.Providers;

namespace Matrix.Patterns;

public static class EAPHelper
{
	public static void FetchAndPrintUser(int userId)
	{
		var eapUserProvider = new EapUserProvider();

		eapUserProvider.GetUserAsync(userId);

		eapUserProvider.GetUserCompleted += (sender, args) =>
		{
			var result = args.Result;
			Console.WriteLine($"ID : {result.Id}\nName{result.Name}");
		};
	}
}