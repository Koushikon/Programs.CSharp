
namespace Thread_1;

public class Multithreadingv6
{
    int totalValues = 0;

    private readonly Mutex _mutex = new();

    /// <summary>
    /// Starts two threads that increment a shared variable using a Mutex for synchronization.
    /// Demonstrates thread-safe access to shared data with a Mutex.
    /// </summary>
    public void UsingMutex_ExecuteCode()
    {
        Thread t1 = new(IncreaseValue);
        Thread t2 = new(IncreaseValue);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Final total values of {nameof(Multithreadingv6)} is:: {totalValues}");
    }

    /// <summary>
    /// Increments the shared variable in a loop using a Mutex for synchronization.
    /// </summary>
    public void IncreaseValue()
    {
        for (int index = 0; index < 100000; index++)
        {
            _mutex.WaitOne();
            try
            {
                // critical section
                totalValues++;
            }
            finally
            {
                _mutex.ReleaseMutex();
            }
        }
    }
}