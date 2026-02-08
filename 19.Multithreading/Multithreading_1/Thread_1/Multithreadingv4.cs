
namespace Thread_1;

public class Multithreadingv4
{
    int totalValues = 0;

    private readonly object _threadLock = new();

    /// <summary>
    /// Starts two threads that increment a shared variable using Monitor for synchronization.
    /// Demonstrates explicit monitor control for thread-safe access.
    /// </summary>
    public void UsingMonitor_ExecuteCode()
    {
        Thread t1 = new(IncreaseValue);
        Thread t2 = new(IncreaseValue);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Final total values of {nameof(Multithreadingv4)} is:: {totalValues}");
    }

    /// <summary>
    /// Increments the shared variable in a loop using Monitor.Enter and Monitor.Exit for synchronization.
    /// </summary>
    public void IncreaseValue()
    {
        for (int index = 0; index < 100000; index++)
        {
            Monitor.Enter(_threadLock);

            try
            {
                totalValues++;
            }
            finally
            {
                Monitor.Exit(_threadLock);
            }
        }
    }
}