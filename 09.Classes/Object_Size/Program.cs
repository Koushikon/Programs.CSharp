
using System.Runtime.InteropServices;

namespace Object_Size;

// Class Type
class A
{
    public int x;
    public double y;
}

// Struct Type
struct B
{
    public int x;
    public double y;
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Size of struct: {Marshal.SizeOf(typeof(B))} bytes.");

        // Can't use Marshal.SizeOf() for classes, but we can estimate
        A obj = new A();
        Console.WriteLine("Class A size can't be determined directly.");
    }
}