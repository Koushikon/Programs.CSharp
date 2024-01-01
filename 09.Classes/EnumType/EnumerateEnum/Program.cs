namespace EnumerateEnum;

/***
 * Enumerate an Enum in C#
 */

internal class Program
{
	static void Main()
	{
		// GetValues takes in Enum type returns the Array type
		var daysOfWeekArray = EnumHelper.GetValues(typeof(DayOfWeek));

		// In order to enamurate we need an enumerable type
		// Then prints the enum name
		foreach (DayOfWeek dayOfWeek in daysOfWeekArray)
		{
			Console.Write($": {dayOfWeek} ");
		}
		Console.WriteLine();

		// In order to enamurate we need an enumerable type
		// Then prints the enum value
		foreach (int dayOfWeek in daysOfWeekArray)
		{
			Console.Write($": {dayOfWeek} ");
		}
		Console.WriteLine();

		// In order to enamurate we need an enumerable type
		// Then prints the enum name and value
		foreach (DayOfWeek dayOfWeek in daysOfWeekArray)
		{
			Console.Write($"{dayOfWeek}: {(int)dayOfWeek} ");
		}
		Console.WriteLine("\n");


		// GetValues takes in Enum type returns the Array type
		var daysOfWeek = EnumHelper.GetValues<DayOfWeek>();

		// In order to enamurate we need an enumerable type
		// Then prints the enum name and value
		foreach (DayOfWeek dayOfWeek in daysOfWeek)
		{
			Console.Write($"{dayOfWeek}: {(int)dayOfWeek} ");
		}
		Console.WriteLine();


		/***
		 * Enumerate an Enum using Reflection
		 */
		var daysOfWeekReflection = EnumHelper.GetValuesWithReflection<DayOfWeek>();
		foreach (var dayOfWeek in daysOfWeekReflection)
		{
			Console.Write($"{dayOfWeek}: {(int)dayOfWeek} ");
		}
		Console.WriteLine();


		Type dayOfWeekEnum = typeof(DayOfWeek);
		var names = dayOfWeekEnum.GetEnumNames();
		foreach (var name in names)
		{
			Console.Write($": {name} ");
		}
		Console.WriteLine();


		var values = dayOfWeekEnum.GetEnumValues();
		foreach (var value in values)
		{
			Console.Write($"{value}: {(int)value} ");
		}
		Console.WriteLine();
	}
}