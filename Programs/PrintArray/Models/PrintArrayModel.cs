namespace PrintArray.Models;

public class PrintArrayModel
{
    // With for loop iterating throught the array and print them
    public void ForLoop(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($" ==> {nums[i]} ");
        }
        Console.WriteLine();
    }


    // With foreach loop iterating throught the array and print them
    public void ForeachLoop(int[] nums)
    {
        foreach (var item in nums)
        {
            Console.Write($" ==> {item} ");
        }
        Console.WriteLine();
    }


    // We need to create a List first then built-in ForEach method lambda expression as a parameter
    public void ToListForEach(int[] nums)
    {
        nums.ToList().ForEach(element => Console.Write($" ==> {element} "));
        Console.WriteLine();
    }


    // With String.Join to print out the array
    public void WithStringJoin(int[] nums)
    {
        Console.WriteLine($" ==> {string.Join("  ==> ", nums)}");
    }


    // With Action Delegate to print the array, Then With ForEach method pass the action as parameter
    // To iterate through the array and print them.
    public void WithStaticArrayClass(int[] nums)
    {
        Action<int> print = (element) => Console.Write($" ==> {element} ");
        Array.ForEach(nums, print);
        Console.WriteLine();
    }


    // Printing out Array elements using AsSpan
    public void WithAsSpan(int[] nums)
    {
        var span = nums.AsSpan();

        for (int i = 0; i < span.Length; i++)
        {
            Console.Write($" ==> {span[i]} ");
        }
        Console.WriteLine();
    }
}
