using Matrix.Patterns;

namespace Matrix;

internal static class Program
{
	static async Task Main(string[] args)
	{
		string fileName = "User.txt";
		string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName + @"\Files\" + fileName);

		// APM Asynchronous programming Pattern
		ApmFileReader apmFileReader = new();
		apmFileReader.BeginReadAsync(path);
		var fileData = apmFileReader.GetData();
		Console.WriteLine($"File Data : {fileData}");

		EAPHelper.FetchAndPrintUser(101);

		await TapHelper.FetchAndPrintUser(101);

		Console.WriteLine("Hello, World!");
	}
}