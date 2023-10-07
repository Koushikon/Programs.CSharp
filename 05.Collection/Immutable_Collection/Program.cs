using System.Collections.Immutable;
using Xunit;

namespace Immutable_Collection;

internal class Program
{
    public static void Main()
    {
        var imList = ImmutableList.Create<int>();
        imList = imList.Add(11);
        Console.WriteLine(imList[0]);

        /*
         * * Immutable Stack
         */
        var imStack1 = ImmutableStack.Create<int>();
        var imStack2 = imStack1.Push(22);
        var imStack3 = imStack2.Push(33);

        Console.WriteLine($"22 = {imStack2.Peek()} is {(22 == imStack2.Peek() ? "same." : "not same.")}");
        Console.WriteLine($"Total size: {imStack3.Count()}");
        Assert.Equal(22, imStack2.Peek());

        var imStack4 = imStack3.Push(44);
        var imStack5 = imStack4.Pop();

        Console.WriteLine($"Last element is {imStack4.Peek}");
        Console.WriteLine($"Total size: {imStack5.Count()}");
        Assert.Equal(44, imStack4.Peek());
        Assert.Equal(33, imStack5.Peek());

        var imStack6 = imStack5.Pop();
        Assert.Equal(22, imStack6.Peek());

        Console.WriteLine($"{new string('-', 15)}\n");

        /*
         * * Immutable Stack
         * * Immutable List
         */

        var imList1 = ImmutableList.Create<int>();
        Assert.Empty(imList1);
        Console.WriteLine($"imList1 is Empty: {imList1.IsEmpty}");

        var imList2 = imList1.Add(14);
        Assert.Single(imList2);
        Console.WriteLine($"imList2 Single element: {imList2.Single<int>()}");

        var imList3 = imList2.Add(24);
        var imList4 = imList3.Add(34);

        Assert.Equal(34, imList4.Last<int>());
        Assert.Equal(3, imList4.Count);
        Console.WriteLine($"imList4 Last element: {imList4.Last<int>()}");
        Console.WriteLine($"imList4 Total elements are: {imList4.Count}");

        var imList5 = imList4.Replace(24, 44);
        Assert.Equal(3, imList5.Count);
        Console.WriteLine($"imList5 Total elements are: {imList5.Count}");

        Console.WriteLine($"{new string('-', 15)}\n");

        /*
         * * Immutable List
         * * Immutable Array
         */

        var imArray = ImmutableArray.Create<int>(1, 2, 3, 4, 6);

        int firstElement = imArray[0];
        Assert.Equal(1, firstElement);
        Console.WriteLine($"imArray First element is: {firstElement}");

        int findElementIndex = imArray.BinarySearch(4);
        Console.WriteLine($"imArray value 4 is Index no: {findElementIndex}");

        Console.WriteLine($"{new string('-', 15)}\n");

        /*
         * * Immutable Array
         * * Immutable Dictionary
         */

        var imDict1 = ImmutableDictionary.Create<char, int>();

        var imDict2 = imDict1.Add('K', 5);
        Assert.Single(imDict2);
        Console.WriteLine($"imDict2 have Single element: {imDict2.Single()}");

        Assert.True(imDict2.ContainsKey('K'));
        Assert.Equal(5, imDict2['K']);
        Console.WriteLine($"imDict2 have K element is: {imDict2.ContainsKey('K')}");

        var imDict3 = imDict2.Add('J', 6);
        Assert.Equal(2, imDict3.Count);
        Console.WriteLine($"imDict3 have Total elements: {imDict3.Count}");

        var imDict4 = imDict3.Remove('K');
        Assert.Single(imDict4);
        Console.WriteLine($"imDict4 now have K element is: {imDict4.ContainsKey('K')}");

        Console.WriteLine($"{new string('-', 15)}\n");

        /*
         * * Immutable Dictionary
         * * Immutable SortedSet
         */

        var imSortSet1 = ImmutableSortedSet<int>.Empty;

        var imSortSet2 = imSortSet1.Add(52);
        var imSortSet3 = imSortSet2.Add(35);

        Assert.Equal(35, imSortSet3[0]);
        Console.WriteLine($"imSortSet3 First element is: {imSortSet3[0]}");

        Assert.Equal(52, imSortSet3[1]);
        Console.WriteLine($"imSortSet3 Second element is: {imSortSet3[1]}");

        var imSortSet4 = imSortSet3.Add(35);
        Assert.Equal(2, imSortSet4.Count);
        Console.WriteLine($"imSortSet4 Total elements are: {imSortSet4.Count}");

        var imSortSet5 = imSortSet4.Remove(35);
        Assert.Single(imSortSet5);
        Console.WriteLine($"imSortSet5 have Single element is: {imSortSet5.Single()}");

        Console.WriteLine($"{new string('-', 15)}\n");
    }
}