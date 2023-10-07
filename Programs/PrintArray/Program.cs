using BenchmarkDotNet.Running;
using PrintArray.Models;

namespace PrintArray;

/***
 * * Source: https://code-maze.com/csharp-print-elements-of-an-array/
 */

internal class Program
{
    static void Main()
    {
        RunAll();

        //BenchmarkRunner.Run<PrintArrayModelBenchmark>();
    }

    private static void RunAll()
    {
        int[] numbers = FillElements(10);
        PrintArrayModel printing = new PrintArrayModel();
        printing.ForLoop(numbers);
        printing.ForeachLoop(numbers);
        printing.ToListForEach(numbers);
        printing.WithStringJoin(numbers);
        printing.WithStaticArrayClass(numbers);
        printing.WithAsSpan(numbers);
    }

    // Fill the elements to array
    private static int[] FillElements(int length)
    {
        int[] nums = new int[length];

        for (int i = 0; i < length; i++)
        {
            var number = new Random().Next(1, 1000);
            nums[i] = number;
        }

        return nums;
    }
}