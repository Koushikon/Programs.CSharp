namespace AsyncBreakfast;

internal class Program
{
	static async Task Main(string[] args)
	{
		/***
		 * After updating the Synchronous code so that the thread doesn't block while tasks are running.
		 * The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.
		 * A simple asynchronous version of the make a breakfast code would look like the following snippet:
		 */

		await AsyncImplementation.ReadyBreakFastFirst();   // Execution Time Apprx: 15 Sec.
		Console.WriteLine();


		/***
		 * Let's make these changes to the breakfast code.
		 * The first step is to store the tasks for operations when they start,
		 * rather than awaiting them:
		 */

		await AsyncImplementation.ReadyBreakFastSecond();  // Execution Time Apprx: 15 Sec.
		Console.WriteLine();

		/***
		 * The Above code won't get your breakfast ready any faster.
		 * The tasks are all awaited as soon as they are started. Next,
		 * you can move the await statements for the bacon and eggs to the end of the method,
		 * before serving breakfast:
		 */

		await AsyncImplementation.ReadyBreakFasyThird();   // Execution Time Apprx: 6 Sec.
		Console.WriteLine();

		/***
		 * Up to this point, you've implicitly assumed that all these tasks complete successfully.
		 * Asynchronous methods throw exceptions, just like their synchronous counterparts.
		 * Asynchronous support for exceptions and error handling strives for the same goals as asynchronous support in general:
		 * You should write code that reads like a series of synchronous statements. Tasks throw exceptions when they can't complete successfully.
		 * The client code can catch those exceptions when a started task is awaited. For example,
		 * let's assume that the toaster catches fire while making the toast.
		 * You can simulate that by modifying the ToastBreadAsync method to match the following code
		 */

		// await AsyncImplementation.ReadyBreakFastFour();    // Getting exception as expected.
		// Console.WriteLine();

		/***
		 * Composition with tasks:
		 * You have everything ready for breakfast at the same time except the toast.
		 * Making the toast is the composition of an asynchronous operation (toasting the bread),
		 * and synchronous operations (adding the butter and the jam).
		 */
		await AsyncImplementation.ReadyBreakFastFive();    // Execution Time Apprx: 6 Sec.
		Console.WriteLine();


		// = = Await tasks efficiently = = //
		// = = = WhenAll and WhenAny = = = //


		/***
		 * WhenAll() method:
		 * The series of await statements at the end of the preceding code can be improved by using methods of the Task class.
		 * One of those APIs is WhenAll, which returns a Task that completes when all the tasks in its argument list have completed,
		 * as shown inside the following code:
		 */
		await AsyncImplementation.ReadyBreakFastSix();     // Execution Time Apprx: 6 Sec.
		Console.WriteLine();


		/***
		 * WhenAny() method:
		 * Another option is to use WhenAny, which returns a Task<Task> that completes when any of its arguments complete.
		 * You can await the returned task, knowing that it has already finished. The following code shows how you could use WhenAny
		 * to await the first task to finish and then process its result. After processing the result from the completed task,
		 * you remove that completed task from the list of tasks passed to WhenAny.
		 */
		await AsyncImplementation.ReadyBreakFastSeven();     // Execution Time Apprx: 6 Sec.
		Console.WriteLine();
	}
}