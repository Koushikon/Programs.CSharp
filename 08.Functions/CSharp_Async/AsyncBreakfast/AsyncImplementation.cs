namespace AsyncBreakfast;

public static class AsyncImplementation
{
	public async static Task ReadyBreakFastFirst()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("coffee is ready");

		Egg eggs = await FryEggsAsync(2);
		Console.WriteLine("eggs are ready");

		Bacon bacon = await FryBaconAsync(3);
		Console.WriteLine("bacon is ready");

		Toast toast = await ToastBreadAsync(2);
		ApplyButter(toast);
		ApplyJam(toast);
		Console.WriteLine("toast is ready");

		Juice oj = PourOJ();
		Console.WriteLine("oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFastSecond()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("Coffee is ready");

		Task<Egg> eggsTask = FryEggsAsync(2);
		Egg eggs = await eggsTask;
		Console.WriteLine("Eggs are ready");

		Task<Bacon> baconTask = FryBaconAsync(3);
		Bacon bacon = await baconTask;
		Console.WriteLine("Bacon is ready");

		Task<Toast> toastTask = ToastBreadAsync(2);
		Toast toast = await toastTask;
		ApplyButter(toast);
		ApplyJam(toast);
		Console.WriteLine("Toast is ready");

		Juice oj = PourOJ();
		Console.WriteLine("Oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFasyThird()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("Coffee is ready");

		Task<Egg> eggsTask = FryEggsAsync(2);
		Task<Bacon> baconTask = FryBaconAsync(3);
		Task<Toast> toastTask = ToastBreadAsync(2);

		Toast toast = await toastTask;
		ApplyButter(toast);
		ApplyJam(toast);
		Console.WriteLine("Toast is ready");
		Juice oj = PourOJ();
		Console.WriteLine("Oj is ready");

		Egg eggs = await eggsTask;
		Console.WriteLine("Eggs are ready");
		Bacon bacon = await baconTask;
		Console.WriteLine("Bacon is ready");

		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFastFour()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("Coffee is ready");

		Task<Egg> eggsTask = FryEggsAsync(2);
		Task<Bacon> baconTask = FryBaconAsync(3);
		Task<Toast> toastTask = ToastBreadAsyncWithException(2);

		Toast toast = await toastTask;
		ApplyButter(toast);
		ApplyJam(toast);
		Console.WriteLine("Toast is ready");
		Juice oj = PourOJ();
		Console.WriteLine("Oj is ready");

		Egg eggs = await eggsTask;
		Console.WriteLine("Eggs are ready");
		Bacon bacon = await baconTask;
		Console.WriteLine("Bacon is ready");

		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFastFive()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("coffee is ready");

		var eggsTask = FryEggsAsync(2);
		var baconTask = FryBaconAsync(3);
		var toastTask = MakeToastWithButterAndJamAsync(2);

		var eggs = await eggsTask;
		Console.WriteLine("eggs are ready");

		var bacon = await baconTask;
		Console.WriteLine("bacon is ready");

		var toast = await toastTask;
		Console.WriteLine("toast is ready");

		Juice oj = PourOJ();
		Console.WriteLine("oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFastSix()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("coffee is ready");

		var eggsTask = FryEggsAsync(2);
		var baconTask = FryBaconAsync(3);
		var toastTask = MakeToastWithButterAndJamAsync(2);

		await Task.WhenAll(eggsTask, baconTask, toastTask);
		Console.WriteLine("Eggs are ready");
		Console.WriteLine("Bacon is ready");
		Console.WriteLine("Toast is ready");

		Juice oj = PourOJ();
		Console.WriteLine("oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}

	public static async Task ReadyBreakFastSeven()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("coffee is ready");

		var eggsTask = FryEggsAsync(2);
		var baconTask = FryBaconAsync(3);
		var toastTask = MakeToastWithButterAndJamAsync(2);

		var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
		while (breakfastTasks.Count > 0)
		{
			Task finishedTask = await Task.WhenAny(breakfastTasks);
			if (finishedTask == eggsTask)
			{
				Console.WriteLine("eggs are ready");
			}
			else if (finishedTask == baconTask)
			{
				Console.WriteLine("bacon is ready");
			}
			else if (finishedTask == toastTask)
			{
				Console.WriteLine("toast is ready");
			}
			await finishedTask;
			breakfastTasks.Remove(finishedTask);
		}

		Juice oj = PourOJ();
		Console.WriteLine("oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}


	// Cooking Methods

	private static Juice PourOJ()
	{
		Console.WriteLine("Pouring orange juice");
		return new Juice();
	}

	private static async Task<Toast> ToastBreadAsync(int slices)
	{
		for (int slice = 0; slice < slices; slice++)
		{
			Console.WriteLine("Putting a slice of bread in the toaster");
		}
		Console.WriteLine("Start toasting...");
		await Task.Delay(3000);
		Console.WriteLine("Remove toast from toaster");

		return new Toast();
	}

	private static async Task<Toast> ToastBreadAsyncWithException(int slices)
	{
		for (int slice = 0; slice < slices; slice++)
		{
			Console.WriteLine("Putting a slice of bread in the toaster");
		}
		Console.WriteLine("Start toasting...");
		await Task.Delay(2000);
		Console.WriteLine("Fire! Toast is ruined!");
		throw new InvalidOperationException("The toaster is on fire");
		await Task.Delay(1000);
		Console.WriteLine("Remove toast from toaster");

		return new Toast();
	}

	private static void ApplyButter(Toast toast) =>
		Console.WriteLine("Putting butter on the toast");

	private static void ApplyJam(Toast toast) =>
		Console.WriteLine("Putting jam on the toast");

	private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
	{
		Toast toast = await ToastBreadAsync(number);
		ApplyButter(toast);
		ApplyJam(toast);

		return toast;
	}

	private static async Task<Bacon> FryBaconAsync(int slices)
	{
		Console.WriteLine($"putting {slices} slices of bacon in the pan");
		Console.WriteLine("cooking first side of bacon...");
		await Task.Delay(3000);
		for (int slice = 0; slice < slices; slice++)
		{
			Console.WriteLine("flipping a slice of bacon");
		}
		Console.WriteLine("cooking the second side of bacon...");
		await Task.Delay(3000);
		Console.WriteLine("Put bacon on plate");

		return new Bacon();
	}

	private static async Task<Egg> FryEggsAsync(int howMany)
	{
		Console.WriteLine("Warming the egg pan...");
		await Task.Delay(3000);
		Console.WriteLine($"cracking {howMany} eggs");
		Console.WriteLine("cooking the eggs ...");
		await Task.Delay(3000);
		Console.WriteLine("Put eggs on plate");

		return new Egg();
	}

	private static Coffee PourCoffee()
	{
		Console.WriteLine("Pouring coffee");
		return new Coffee();
	}
}