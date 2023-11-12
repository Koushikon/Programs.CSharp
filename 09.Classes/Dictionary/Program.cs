using System.Collections.Generic;


var playItem = new Dictionary<string, int>
{
    { "Bat", 10 },
    { "Ball", 20 },
    { "Gloves", 30 },
    { "Wicket", 40 },
};


// Display Dictionary items
foreach (var item in playItem)
{
    Console.WriteLine($"\tKey: {item.Key} Value: {item.Value}");
}
Console.WriteLine();



// Return Default value from the Dictionary
string searchKey = "Chimni";    // Non Existing Search Key
int result = 0; // reset value

// using ContainsKey() takes 49.27 ns
result = playItem.ContainsKey(searchKey) ? playItem[searchKey] : default;
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");

// using TryGetValue() takes 23.44 ns
result = playItem.TryGetValue(searchKey, out result) ? result : default;
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");

// using GetValueOrDefault() takes 23.23 ns
result = playItem.GetValueOrDefault(searchKey);
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");


searchKey = "Gloves";    // Existing Search Key
result = 0; // reset value

// using ContainsKey() takes 13.03 ns
result = playItem.ContainsKey(searchKey) ? playItem[searchKey] : default;
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");

// using TryGetValue() takes 11.85 ns
result = playItem.TryGetValue(searchKey, out result) ? result : default;
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");

// using GetValueOrDefault() takes 14.04 ns
result = playItem.GetValueOrDefault(searchKey);
Console.WriteLine($"Searched Key: {searchKey} Item found: {result}");