
using Matrix.Models;
using System.Collections;

/***
 * Learn Source:
 */

namespace Matrix;

internal static class Program
{
    public static void Main()
    {
        User userFirst = new();
        userFirst.Id = 1;
        userFirst.FirstName = "Koushik";
        userFirst.LastName = "Saha";
        Console.WriteLine(userFirst.ToString());

        Console.WriteLine(1);

        // Creates an empty Hashtable
        var hTable1 = CreateEmptyHashTable();

        // Creates an Hashtable with Initial Capacity
        var hTable2 = CreateHashTableWithInitialCapacity(5);

        // Creates a Hashtable from a Dictionary
        var hTable3 = CreateHashTableFromDictionary(SharedData.userDictionary);
        PrintContent(hTable3);

        Console.WriteLine(2);

        // Creates Hashtable from a List
        var hTable4 = AddSampleDataToHashtable(SharedData.UserList);
        PrintContent(hTable4);

        Console.WriteLine(3);

        // Retrive single element from a Hashtable
        var userSecond = RetriveSingleElementFromHashtable(hTable4, 2);
        PrintContent(new List<User>() { userSecond });

        Console.WriteLine(4);

        // Retrive all element from a Hashtable
        var usersFirst = RetriveAllElementFromHashtable(hTable4);
        PrintContent(usersFirst);

        Console.WriteLine(5);

        // Update a element in Hashtable
        hTable4 = UpdateElementInHashtable(hTable4, id: 2, name: "Ashish Dam");
        PrintContent(hTable4);

        Console.WriteLine(6);

        // Remove single element from Hashtable
        hTable4 = RemoveSingleElementFromHashtable(hTable4, id: 2);
        PrintContent(hTable4);

        Console.WriteLine(7);

        // Remove All element from Hashtable
        hTable4 = RemoveAllElementFromHashtable(hTable4);
        PrintContent(hTable4);

        Console.WriteLine(8);

        // Creates a Shallow copy of our Hashtable
        hTable4 = AddSampleDataToHashtable(SharedData.UserList);
        var hTable5 = CloneHashTable(hTable4);
        hTable4 = UpdateElementInHashtable(hTable4, id: 2, name: "Dinesh Ghosh");
        PrintContent(hTable5);

        Console.WriteLine(9);

        // Synchronized() method to create a thread-safe wrapper for our Hashtable
        SynchronizeHashtable(hTable5);

        Console.WriteLine(10);

        Console.WriteLine("End of program.");
    }

    public static void PrintContent(List<User> users)
    {
        if (users.Count == 0)
        {
            Console.WriteLine("Empty List");
        }

        foreach (var user in users)
        {
            // Same userSecond or userSecond.ToString()
            Console.WriteLine($"Id: {user.Id} & Name: {user}");
        }
    }

    public static void PrintContent(Hashtable userHashTable)
    {
        if (userHashTable.Count == 0)
        {
            Console.WriteLine("Empty Hashtable");
        }

        foreach (DictionaryEntry item in userHashTable)
        {
            Console.WriteLine($"UserId: {item.Key} & UserValue: {item.Value}");
        }
    }

    // Creates an empty Hashtable and return it
    public static Hashtable CreateEmptyHashTable() => new();

    // Creates an Hashtable with Initial Capacity and return it
    public static Hashtable CreateHashTableWithInitialCapacity(int initialCapacity)
    => new(initialCapacity);

    // Creates a Hashtable from a Dictionary and return it
    public static Hashtable CreateHashTableFromDictionary(Dictionary<int, User> dictionary)
    => new(dictionary);

    // Add data to a Hashtable from Users List and return it
    public static Hashtable AddSampleDataToHashtable(List<User> users)
    {
        Hashtable hashtable = new Hashtable();

        foreach (User user in users)
        {
            hashtable.Add(user.Id, user);
        }

        return hashtable;
    }

    // Retrive Single element from a Hashtable
    public static User RetriveSingleElementFromHashtable(Hashtable hashtable, int id)
    {
        if (hashtable.ContainsKey(id))
        {
            return (User)hashtable[id]!;
        }

        return default!;
    }

    // Retrive All element from a Hashtable
    public static List<User> RetriveAllElementFromHashtable(Hashtable hashtable)
    {
        var usersList = new List<User>(hashtable.Count);

        foreach (DictionaryEntry entry in hashtable)
        {
            usersList.Add((User)entry.Value!);
        }

        return usersList;
    }

    // Updaye a element from Hashtable
    public static Hashtable UpdateElementInHashtable(Hashtable hashtable, int id, string name)
    {
        string[] namePart = name.Split(" ");

        if (hashtable.ContainsKey(id))
        {
            hashtable[id] = new User() { Id = id, FirstName = namePart[0], LastName = namePart[1] };
        }

        return hashtable;
    }

    // Remove single element from Hashtable
    public static Hashtable RemoveSingleElementFromHashtable(Hashtable hashtable, int id)
    {
        hashtable.Remove(id);

        return hashtable;
    }

    // Remove All element from Hashtable
    public static Hashtable RemoveAllElementFromHashtable(Hashtable hashtable)
    {
        hashtable.Clear();

        return hashtable;
    }

    // Creates a Shallow copy of our Hashtable
    public static Hashtable CloneHashTable(Hashtable hashTable)
    {
        return (Hashtable)hashTable.Clone();
    }

    /***
     * Synchronized() method to create a thread-safe wrapper for our Hashtable
     * 
     * The wrapper we generate by invoking this method enables concurrent access for multiple users to read and write data from the collection.
     * This function ensures thread safety. However, this wrapper restricts the write operations to only one writer at a time.
     */
    public static Hashtable SynchronizeHashtable(Hashtable hashtable)
    {
        return Hashtable.Synchronized(hashtable);
    }
}