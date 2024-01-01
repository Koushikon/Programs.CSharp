namespace AsyncMethods;

internal class Program
{
	static async Task Main(string[] args)
	{
		// Can be called through Synchronous method
		UseTaskCompletionAsync();


        // Can be called through Synchronous method
        UseTaskCompleteSync();

		// Can be called through Asynchronous method
		await UseTaskFromResultAsync();

		UseTaskFromResultSync();

        // Calling a Non-Asynchronous method
        await MyOldTaskParallelLibraryCode();

        Console.WriteLine("Goo Night world!");
	}


	/***
	 * Task.CompletedTask
	 * We can consider using this method that only returns a task without actually performing any asynchronous work. 
	 */

	static Task UseTaskCompletionAsync()
	{
		Console.WriteLine("Not performing any asynchronous work.");

		return Task.CompletedTask;
	}

    static Task MyOldTaskParallelLibraryCode()
    {
        // Note that this is not an async method, so we can't use await in here.
        Console.WriteLine("Not performing any asynchronous work.");

        return Task.CompletedTask;
    }


    /***
	 * Task.CompletedTask.Wait()
	 * Using it in a synchronous method isn’t a recommended practice, as it can lead to blocking the current thread,
	 * defeating the purpose of asynchronous programming.
	 * 
	 * Recognizing that blocking threads in synchronous contexts can lead to
	 * real-world performance and scalability issues is critical.
	 */

    static void UseTaskCompleteSync()
	{
		Console.WriteLine("Not performing any asynchronous work.");

		Task.CompletedTask.Wait();
	}


	/***
	 * Task.FromResult
	 * The Task.FromResult is a sibling to Task.CompletedTask.
	 * It is a useful method in async programming to create a completed Task with a specific result.
	 * It also allows us to quickly return a completed Task in situations where we don’t have asynchronous operations.
	 */
	static async Task<string> UseTaskFromResultAsync()
	{
		Console.WriteLine("Not performing any asynchronous work but returning result.");

		var message = "Hello Worls";
		return await Task.FromResult(message);
	}


	/***
	 * Task.FromResult().Result
	 * In synchronous methods, we could also potentially use Task.FromResult, however,
	 * its usage might not align with the typical intention of synchronous methods:
	 */

	static string UseTaskFromResultSync()
	{
		Console.WriteLine("Not performing any asynchronous work but returning result.");

		var message = "Hello Worls";
		return Task.FromResult(message).Result;
	}


	/***
	 *  If our asynchronous method does perform actual asynchronous work,
	 *  we’ll use the return statement. This will signify an ongoing asynchronous operation.
	 *  Therefore, the caller is notified that we are working asynchronously,
	 *  with a task representing progress and completion.
	 */

	static async Task<int> UseReturnAsunc()
	{
		Console.WriteLine("About to perform some asunchronous work.");
		
		await Task.Delay(1000);

		return 5;
	}
}