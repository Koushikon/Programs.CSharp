/**
 * * Tuples:
 * * useful for return multiple values from Methods
 */

// Approach 1
var reult_1 = ValidAddress_1("Kolkata");

if (reult_1.Item2)
    Console.WriteLine($"Address is: {reult_1.Item1}");
else
    Console.WriteLine($"Address is Not Found.");

(string, bool) ValidAddress_1(string address)
{
    return (address.Equals("Kolkata")) ? (address, true) : (address, false);
}


// Approach 2 - With Proper Name instead of Item1, Item2
var reult_2 = ValidAddress_2("Cooch Behar");

if (reult_2.isValid)
    Console.WriteLine($"Address is: {reult_2.address}");
else
    Console.WriteLine($"Address is Not Found.");

// With Deconstructor
(string Address_2, bool IsValid_2) = ValidAddress_2("Cooch Behar");

(string Address_3, _) = ValidAddress_2("Cooch Behar"); // With Discards character

if (IsValid_2)
    Console.WriteLine($"Address is: {Address_2}");
else
    Console.WriteLine($"Address is Not Found.");


(string address, bool isValid) ValidAddress_2(string address)
{
    return (address.Equals("Cooch Behar")) ? (address, true) : (address, false);
}