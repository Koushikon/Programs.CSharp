namespace Threading_Mutex.Models;

/***
 * Source of learning: https://code-maze.com/csharp-how-to-use-mutex-class/
 * Mutex is a synchronization primitives that the operating system
 * provides which we can use in C#. Simply put, a Mutex restricts access
 * to a resource so that only one thread can access it at a time.
 */

public static class ThreadEntity
{
    /// <summary>
    /// Writes numbers 0 to 50 to the specified file without any synchronization.
    /// If executed concurrently, multiple threads may interleave their output, causing mixed number streams in the file.
    /// </summary>
    /// <param name="fileName">The file to which numbers will be appended.</param>
    public static void WriteNumbers_NoMutex(string fileName)
    {
        for (int num = 0; num <= 50; num++)
        {
            File.AppendAllText(fileName, $"{num} ");
            Thread.Sleep(1000);
        }
    }


    /// <summary>
    /// Writes numbers 0 to 50 to the specified file using a named Mutex for synchronization.
    /// Only one thread at a time can write to the file, preventing interleaved output.
    /// This version does not handle exceptions or abandoned mutexes.
    /// </summary>
    /// <param name="fileName">The file to which numbers will be appended.</param>
    public static void WriteNumbers_Mutex_Improper(string fileName)
    {
        using var metux = new Mutex(initiallyOwned: false, "Global\\numbers_output");

        metux.WaitOne();

        for (int num = 0; num <= 50; num++)
        {
            File.AppendAllText(fileName, $"{num} ");
            Thread.Sleep(100);
        }

        metux.ReleaseMutex();
    }


    /// <summary>
    /// Writes numbers 0 to 50 to the specified file using a named Mutex for synchronization.
    /// Handles the case where the Mutex is abandoned by catching <see cref="AbandonedMutexException"/>.
    /// Ensures the Mutex is always released, even if an exception occurs during writing.
    /// </summary>
    /// <param name="fileName">The file to which numbers will be appended.</param>
    public static void WriteNumbers_Mutex(string fileName)
    {
        using var metux = new Mutex(initiallyOwned: false, "Global\\numbers_output");

        try
        {
            metux.WaitOne();
        }
        catch (AbandonedMutexException)
        {
            File.AppendAllText(fileName, string.Empty);
        }

        try
        {
            for (int num = 0; num <= 50; num++)
            {
                File.AppendAllText(fileName, $"{num} ");
                Thread.Sleep(100);
            }
        }
        finally
        {
            metux.ReleaseMutex();
        }
    }
}
