
namespace DateTimeTypes;

internal class Program
{
    static void Main()
    {
        // DateTime declaration
        // Saves only DateTime data
        var dateTime = DateTime.Now;
        Console.WriteLine($"DateTime: {dateTime}");

        // DateTimeOffset declaration
        // Saves DateTime and Offset Data
        var dateTimeOffset = DateTimeOffset.Now;
        Console.WriteLine($"DateTime Offset: {dateTimeOffset}");

        // Get all the time zones of same offset
        var timeZones = GetTimeZoneFromOffset(dateTimeOffset.Offset);
        foreach (TimeZoneInfo timeZone in timeZones)
        {
            Console.WriteLine($"Time Zone: {timeZone}");
        }
        Console.WriteLine();

        //  Specify the DateTime Kind as Utc
        var dateTimeUtc = DateTime.UtcNow;
        Console.WriteLine($"DateTime Kind: {dateTimeUtc.Kind}");

        //  Specify the DateTime Kind as Local Time
        var dateTimeLocal = DateTime.Now;
        Console.WriteLine($"DateTime Kind: {dateTimeLocal.Kind}");

        //  Specify the DateTime Kind as Unspecified
        var dateTimeUnspecified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);
        Console.WriteLine($"DateTime Kind: {dateTimeUnspecified.Kind}");
    }

    // return the same offset time zones as a list
    static List<TimeZoneInfo> GetTimeZoneFromOffset(TimeSpan offset) =>
        TimeZoneInfo.GetSystemTimeZones()
        .Where(tz => tz.BaseUtcOffset == offset)
        .ToList();
}