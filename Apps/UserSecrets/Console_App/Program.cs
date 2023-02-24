using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            Console.WriteLine($"Hello, {config["connectionstrings"]}");
        }
    }
}