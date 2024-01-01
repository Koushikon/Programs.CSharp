namespace SmartEnum;

/***
 * Git Repo: https://github.com/ardalis/SmartEnum
 */

internal class Program
{
	static void Main()
	{
		var dev = new Developer("Koushik", DeveloperLevel.Senior);

		Console.WriteLine($"{dev.Name} is a {dev.Level} developer.");
		Console.WriteLine($"{dev.Name}'s productivity is {dev.Level.Productivity} lines/hour.");
		Console.WriteLine($"The developer can write 500 lines of code in {dev.WriteCode(500):F2} hours.");


		// These pre-defined methods – FromName and FromValue that we can use to create an enumeration of DeveloperLevel type. 
		var juniotFromName = DeveloperLevel.FromName("Junior");
		var juniotFromValue = DeveloperLevel.FromValue(1);

		Console.WriteLine(juniotFromName == juniotFromValue);

		if (DeveloperLevel.TryFromName("Regular", out var regularFromName))
		{
			Console.WriteLine($"Created enumuration from name: {regularFromName.Name}");
		}

		if (DeveloperLevel.TryFromValue(3, out var regularFromValue))
		{
			Console.WriteLine($"Created enumuration from value: {regularFromValue.Name}");
		}

		// We can access the list of enumerations with the List property:
		Console.WriteLine($"The {nameof(DeveloperLevel)} has {DeveloperLevel.List.Count} different enumurations.");

		foreach (var item in DeveloperLevel.List)
		{
			Console.Write($" {item.Name} ");
		}
		Console.WriteLine();
	}
}