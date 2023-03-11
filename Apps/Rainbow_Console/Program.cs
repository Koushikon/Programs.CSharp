using Spectre.Console;

namespace Rainbow_Console
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read More: https://spectreconsole.net/quick-start");
            AnsiConsole.Markup("[underline red]Hello[/] World!\n");

            var result = DPrompt();
            var result2 = DPrompt2();

            var table = new Table().Centered();

            AnsiConsole.Live(table)
                .Start(ctx =>
                {
                    table.AddColumn("Foo");
                    ctx.Refresh();
                    Thread.Sleep(1000);

                    table.AddColumn("Bar");
                    ctx.Refresh();
                    Thread.Sleep(1000);
                });



            // Console choose Menu Prompt
            var fruit = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("What's your [green]favorite fruit[/]?")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]") // Shows when to many results
                .AddChoices(new[] {
                    "Apple", "Apricot", "Avocado",
                    "Banana", "Blackcurrant", "Blueberry",
                    "Cherry", "Cloudberry", "Cocunut",
                    "Biscuit", "Chocolate"
                }));

            // Echo the fruit back to the terminal
            AnsiConsole.WriteLine($"I agree. {fruit} is tasty!");
        }

        private static bool DPrompt()
        {
            if (!AnsiConsole.Confirm("Run prompt example?"))
            {
                AnsiConsole.MarkupLine("Ok... :(");
                return false;
            }

            return true;
        }

        private static string DPrompt2()
        {
            var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
            return name;
        }
    }
}