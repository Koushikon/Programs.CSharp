# Identify String Is Number

This project implements checking if a given string is a number using following different approaches. Also benchmarking them to see which approach is faster in performance.

## To Run the Benchmark
1. Commented in the `RunAll` method code in `Program.cs`.
2. Commented out this line in `Program.cs`.
	- `BenchmarkRunner.Run<StringIsANumberBenchmark>();`
3. The, Open terminal navigate to the project folder.
4. Run this command `dotnet run --project <project_name>.csproj -c Release`.
5. This will start the Benchmarking process.