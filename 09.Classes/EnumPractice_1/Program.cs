using EnumPractice_1;

// Get Enum Value by Type
byte type = (byte)RequestType.HttpGet;
Console.WriteLine(type);

// Get Enum Type name by Value
RequestType requestType = (RequestType)2;
Console.WriteLine(requestType);

// Use GetName() to retrive names of enum
Array.ForEach(Enum.GetNames(typeof(RequestType)), x => Console.Write($"{x} "));
Console.WriteLine();

// Use GetValues() to retrive values of enum
Array.ForEach((byte[])Enum.GetValues(typeof(RequestType)), x => Console.Write($"{x} "));
Console.WriteLine();

// By Parsing
RequestType fromString = (RequestType)Enum.Parse(typeof(RequestType), "2");
Console.WriteLine(fromString);

// To check wheather the value is defined in Enum or not
bool hasValue = Enum.IsDefined(typeof(RequestType), (byte)2);
Console.WriteLine(hasValue);

bool notHasValue = Enum.IsDefined(typeof(RequestType), "7");
Console.WriteLine(notHasValue);