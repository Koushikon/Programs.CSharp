namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 45;

            var message = age switch
            {
               > 100 => "You're Legend",
               > 80 => "Getting Started",
               > 60 => "Well Thank You",
               > 40 => "Work the hell out",
               > 20 => "Have some fun",
               _ => "Do It."
            };
            Console.WriteLine(message);

            // With C# 11 and .Net 7 we could add above logic Inside String Interpolation
            Console.WriteLine($"Your Age is: {age}, Our suggestion is: {age switch
            {
                > 100 => "You're Legend",
                > 80 => "Getting Started",
                > 60 => "Well Thank You",
                > 40 => "Work the hell out",
                > 20 => "Have some fun",
                _ => "Do It."
            }}");
        }
    }
}