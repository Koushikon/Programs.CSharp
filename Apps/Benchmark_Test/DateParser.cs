
namespace Benchmark_Test;

public class DateParser
{
    public int GetYearFromDT(string pDateTime)
    {
        var dateTime = DateTime.Parse(pDateTime);
        return dateTime.Year;
    }

    public int GetYearFromSplit(string pDateTime)
    {
        var dateTime = pDateTime.Split('-');
        return int.Parse(dateTime[0]);
    }

    public int GetYearFromSubString(string pDateTime)
    {
        var indexOfHiphen = pDateTime.IndexOf('-');
        return int.Parse(pDateTime.Substring(0, indexOfHiphen));
    }

    public int GetYearFromSpan(ReadOnlySpan<Char> pDateTime)
    {
        var indexOfHiphen = pDateTime.IndexOf('-');
        return int.Parse(pDateTime.Slice(0, indexOfHiphen));
    }

    public int GetYearFromSpanManualConvertion(ReadOnlySpan<Char> pDateTime)
    {
        var indexOfHiphen = pDateTime.IndexOf('-');
        var yearAsSpan = pDateTime.Slice(0, indexOfHiphen);

        var temp = 0;
        for(int i = 0; i < yearAsSpan.Length; i++)
        {
            temp = temp * 10 + (yearAsSpan[i] - '0');
        }

        return temp;
    }
}
