using ReturnMultipleValue.Models;

namespace ReturnMultipleValue.Models;

public static class MultipleValuesRunner
{
    // using Tuple as return type
    public static Tuple<string, bool, int> GetValuesUsingTuple()
    {
        string name = "Pizza";
        bool orderComplete = false;
        int price = int.MaxValue;

        return Tuple.Create(name, orderComplete, price);
    }

    // using Tuple destructuring return type
    public static (string stringValue, bool boolValue, int intValue) GetValuesUsingTupleLiterals()
    {
        string name = "Pizza";
        bool orderComplete = false;
        int price = int.MaxValue;

        return (name, orderComplete, price);
    }

    // using 
    public static void GetValuesUsingOutKeyword(out int ItemId, out bool IsOn, out string ItemName)
    {
        ItemId = 17;
        IsOn = false;
        ItemName = "Pandora Box";
    }

    // using class as the return type
    public static MultipleValues GetValuesUsingObjectInstance()
    {
        MultipleValues values = new MultipleValues
        {
            StringValue = "Magic 101 Guide",
            BoolValue = false,
            IntValue = 15
        };

        return values;
    }

    // using Dictionary as the return type 
    public static Dictionary<string, object> GetValuesUsingDictionary()
    {
        Dictionary<string, object> obj = new Dictionary<string, object>();
        obj.Add("stringValue", "Magic Bullet");
        obj.Add("boolValue", false);
        obj.Add("intValue", 27);

        return obj;
    }


    // using Array of objects as return type
    public static object[] GetValuesUsingArrayOfObject()
    {
        return new object[] { "Jack & Jill", false, 57 };
    }
}