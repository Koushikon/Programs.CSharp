using System.Reflection;

namespace EnumerateEnum;

internal class EnumHelper
{
	public static Array GetValues(Type type)
	{
		return Enum.GetValues(type);
	}


	public static IEnumerable<TEnum> GetValues<TEnum>() where TEnum : struct, Enum
	{
		return Enum.GetValues<TEnum>();
	}


	public static TEnum[] GetValuesWithReflection<TEnum>() where TEnum : Enum
	{
		// This will give us FieldInfo for each of the enumeration values.
		FieldInfo[] fields = typeof(DayOfWeek).GetFields(BindingFlags.Static | BindingFlags.Public);

		return fields.Select(x => x.GetValue(null))
			.Cast<TEnum>()
			.ToArray();
	}
}