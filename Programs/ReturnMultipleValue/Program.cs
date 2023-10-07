using System.Collections.Generic;
using ReturnMultipleValue.Models;

namespace ReturnMultipleValue;

public class Program
{
    public static void Main()
    {
        // saves the return value in a single Tuple variable then print them all
        var resultTyple = MultipleValuesRunner.GetValuesUsingTuple();
        Console.WriteLine($"Item 1: {resultTyple.Item1}, Item 2: {resultTyple.Item2}, Item 3: {resultTyple.Item3}");


        // saves the return value in a single Tuple variable then print them all
        var (stringValue, boolValue, intValue) = MultipleValuesRunner.GetValuesUsingTupleLiterals();
        Console.WriteLine($"Item 1: {stringValue}, Item 2: {boolValue}, Item 3: {intValue}");


        // passing the variables with out then after modifting print them all
        int ItemId;
        bool IsOn;
        string ItemName;
        MultipleValuesRunner.GetValuesUsingOutKeyword(out ItemId, out IsOn, out ItemName);
        Console.WriteLine($"Item 1: {ItemId}, Item 2: {IsOn}, Item 3: {ItemName}");


        // saveing the returning object then print them all
        var mVObj = MultipleValuesRunner.GetValuesUsingObjectInstance();
        Console.WriteLine($"Item 1: {mVObj.StringValue}, Item 2: {mVObj.BoolValue}, Item 3: {mVObj.IntValue}");


        // saving the Dictionary object then print them all
        var dictObj = MultipleValuesRunner.GetValuesUsingDictionary();
        Console.WriteLine($"Item 1: {dictObj["stringValue"]}, Item 2: {dictObj["boolValue"]}, Item 3: {dictObj["intValue"]}");


        // saving the Array of object then print them all
        var arrayObj = MultipleValuesRunner.GetValuesUsingArrayOfObject();
        Console.WriteLine($"Item 1: {arrayObj[0]}, Item 2: {arrayObj[1]}, Item 3: {arrayObj[2]}");
    }
}