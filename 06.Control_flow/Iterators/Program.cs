using System.Collections;

namespace Iterators;

/***
 * C# ITERATORS
 */

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Iterators Starting: ");

        foreach (int item in Numbers())
        {
            Console.Write($" {item} :");
        }
        Console.WriteLine();

        foreach (int item in EvenSequence(10, 20))
        {
            Console.Write($" {item} :");
        }
        Console.WriteLine();

        DaysOfWeek dok = new DaysOfWeek();

        foreach (string item in dok)
        {
            Console.Write($" {item} :");
        }
        Console.WriteLine();
    }

    /***
     * The return type of an iterator method or get accessor can be 
     * IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>.
     */
    public static IEnumerable Numbers()
    {
        yield return 3;
        yield return 5;
        yield return 8;
    }

    public static IEnumerable<int> EvenSequence(int first, int last)
    {
        for (int i = first; i < last; i++)
        {
            if(i % 2 == 0)
            {
                yield return i;
            }
        }
    }
}

/***
 * The DaysOfTheWeek class implements the IEnumerable interface, which requires a GetEnumerator method.
 * The compiler implicitly calls the GetEnumerator method, which returns an IEnumerator.
 * 
 * The GetEnumerator method returns each string one at a time by using the yield return statement.
 */
public class DaysOfWeek : IEnumerable
{
    private string[] Days = { "Sun", "Mon", "Tues", "Wednes", "Thurs", "Fri", "Satur" };

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < Days.Length; i++)
        {
            yield return Days[i];
        }
    }
}