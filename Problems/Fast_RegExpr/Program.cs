using System.Text.RegularExpressions;
using BenchmarkDotNet.Running;
using Fast_RegExpr.ExecTime;

namespace Fast_RegExpr;

/**
 * * Source: https://www.c-sharpcorner.com/article/the-fastest-way-to-use-regular-expressions-in-microsoft-net-7/
 */

public class Program
{
    public static void Main()
    {
        /**
         * ? Try Catch Performance Measure
         * * To Run:
         * * dotnet run
         */
        // TryCatchMeasure measure = new TryCatchMeasure();

        /**
         * ? Benchmark Performance Measure
         * * To Run:
         * * dotnet build -c release
         * * dotnet <dll_path>
         */
        BenchmarkRunner.Run<BenchmarkMeasure>();
    }
}

