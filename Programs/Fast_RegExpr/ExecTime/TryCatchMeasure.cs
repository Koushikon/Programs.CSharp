using System.Diagnostics;
using Fast_RegExpr.Model;

namespace Fast_RegExpr.ExecTime;

public class TryCatchMeasure
{
    // 1st Way: Previous
    private const string _email = "asman@galaxy.com";

    public TryCatchMeasure()
    {
        ContainsWord_1();
        ContainsWord_2();
        ContainsWord_3();
    }

    public void ContainsWord_1()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        try
        {
            var result1 = RegexMatch.ContainsWord_1(_email);
            Console.WriteLine(result1);
        }
        finally
        {
            sw.Stop();
            Console.WriteLine($"Took {sw.ElapsedMilliseconds}ms");
        }
    }


    public void ContainsWord_2()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        try
        {
            var result1 = RegexMatch.ContainsWord_2(_email);
            Console.WriteLine(result1);
        }
        finally
        {
            sw.Stop();
            Console.WriteLine($"Took {sw.ElapsedMilliseconds}ms");
        }
    }


    public void ContainsWord_3()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        try
        {
            var result1 = RegexMatch.ContainsWord_3(_email);
            Console.WriteLine(result1);
        }
        finally
        {
            sw.Stop();
            Console.WriteLine($"Took {sw.ElapsedMilliseconds}ms");
        }
    }
}