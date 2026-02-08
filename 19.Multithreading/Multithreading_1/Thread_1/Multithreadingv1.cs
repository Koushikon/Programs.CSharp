
namespace Thread_1;

public class Multithreadingv1
{
    int totalValues = 0;
    private readonly object _threadLock = new();

    // Can use 'System.Threading.Lock' in C# 13 (.NET 9.0)
    // private readonly System.Threading.Lock _balanceLock = new();

    /// <summary>
    /// Starts two threads that increment a shared variable without synchronization.
    /// Demonstrates race conditions in multithreading.
    /// </summary>
    public void ExecuteCode()
    {
        // create two threads
        Thread thread_1 = new(IncreaseValue);
        Thread thread_2 = new(IncreaseValue);

        thread_1.Start();
        thread_2.Start();

        // blocks the calling thread 
        thread_1.Join();
        thread_2.Join();

        Console.WriteLine($"Final total values of {nameof(Multithreadingv1)} is:: {totalValues}");
    }

    /// <summary>
    /// Increments the shared variable in a loop. Not thread-safe.
    /// </summary>
    public void IncreaseValue()
    {
        for (int index = 0; index < 100000; index++)
        {
            // critical section
            totalValues++;
        }
    }
}