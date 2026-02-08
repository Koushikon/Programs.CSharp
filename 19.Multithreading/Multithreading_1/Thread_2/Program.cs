using Thread_2;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Process {Environment.ProcessId} started");

        MultiThreadingv1 app = new();
        app.ExecuteCode();

        Console.WriteLine($"Process {Environment.ProcessId} finished");
        Console.ReadKey();
    }
}