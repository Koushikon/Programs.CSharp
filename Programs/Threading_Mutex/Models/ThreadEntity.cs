namespace Threading_Mutex.Models;

/***
 * Source of learning: https://code-maze.com/csharp-how-to-use-mutex-class/
 * Mutex is a synchronization primitives that the operating system
 * provides which we can use in C#. Simply put, a Mutex restricts access
 * to a resource so that only one thread can access it at a time.
 */

public static class ThreadEntity
{
    /***
     * With No Mutex part
     * 
     * we haven’t implemented any synchronization between threads or processes yet.
     * If we execute this code multiple times simultaneously,
     * we will see multiple different number streams interweaved into the file.
     */
    public static void WriteNumbers_NoMutex(string fileName)
    {
        for (int num = 0; num <= 50; num++)
        {
            File.AppendAllText(fileName, $"{num} ");
            Thread.Sleep(1000);
        }
    }


    /***
     * To Fix WriteNumbers_NoMutex : With Mutex part
     * 
     * Now, even if we run this code multiple times simultaneously,
     * we won’t get any interweaving between the different number streams.
     * That’s because we’re only writing to the file while we have ownership of the Mutex,
     * and that can only be the case with one thread at a time.
     */
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


    /***
     * What will happen if the Mutex is abondoned and we try to accure it.
     * To Fix:
     */
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
