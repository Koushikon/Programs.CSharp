namespace NullParameterCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? info = null;
            info = string.Empty;

            SayHii(info);
        }

        static void SayHii(string? message)
        {
            //if (message is null)
            //{
            //    throw new ArgumentNullException(nameof(message));
            //}

            // null checking improvements
            // WIth C# 11 WE can do above code in single line statement.
            ArgumentException.ThrowIfNullOrEmpty(message);

            Console.WriteLine($"Hello, {message}.");
        }
    }
}