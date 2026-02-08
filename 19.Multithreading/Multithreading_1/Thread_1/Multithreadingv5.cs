
namespace Thread_1;

public class Multithreadingv5
{
    int totalValues = 0;

    private readonly object _threadLock = new();

    /// <summary>
    /// Starts two threads that increment a shared variable using Monitor.TryEnter with a timeout for synchronization.
    /// Demonstrates timed attempts to enter the critical section.
    /// </summary>
    public void UsingMonitorWaitTime_ExecuteCode()
    {
        Thread t1 = new(IncreaseValue);
        Thread t2 = new(IncreaseValue);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Final total values of {nameof(Multithreadingv5)} is:: {totalValues}");
    }

    /// <summary>
    /// Increments the shared variable in a loop, attempting to enter the critical section with a timeout using Monitor.TryEnter.
    /// Logs if the thread fails to acquire the lock within the timeout.
    /// </summary>
    public void IncreaseValue()
    {
        for (int index = 0; index < 100000; index++)
        {
            if (Monitor.TryEnter(_threadLock, 500))
            {
                try
                {
                    // critical section:
                    Console.WriteLine($"{Environment.CurrentManagedThreadId} is processing something.");

                    // simulate long running processing
                    Thread.Sleep(1000);

                    totalValues++;
                }
                finally
                {
                    Monitor.Exit(_threadLock);
                }
            }
            else
            {
                Console.WriteLine($"{Environment.CurrentManagedThreadId} gives up to wait to enter critical section");
            }
        }
    }
}