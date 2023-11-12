using Matrix.Models;
using Matrix.Providers;

namespace MatrixTest;

public class AsyncTester
{
	[Fact]
	public void WhenUserFetchedUsingEvent_ThenUserReturned()
	{
		var userProvider = new EapUserProvider();

		userProvider.GetUserAsync(101, null);

		userProvider.GetUserCompleted += (sender, args) =>
		{
			var user = args.Result;
			Assert.NotNull(user);
			Assert.Equal(101, user.Id);
			Assert.Equal("Selim", user.Name);
		};
	}


	[Fact]
	public async Task WhenUserFetchedUsingTask_ThenUserReturned()
	{
		var userProvider = new TapUserProvider();

		var user = await userProvider.GetUserAsync(101);

		Assert.NotNull(user);
		Assert.Equal(101, user.Id);
		Assert.Equal("Selim", user.Name);
	}
}