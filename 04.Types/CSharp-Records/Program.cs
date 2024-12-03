using CSharp_Records.Class;

namespace CSharp_Records;

public record IceCream(string flavor, string color);

public record NuttyIceCream(string flavor, string color, string seedType)
    : IceCream(flavor, color);

public record VeganIceCream(string flavor, string color, string seedType, string[] Ingredients)
    : NuttyIceCream(flavor, color, seedType);

public class Program
{
    public static void Main(string[] args)
    {
        IceCream iceCream = new("Pistachio", "Green");
        Console.WriteLine(iceCream);
        // IceCream { flavor = Pistachio, color = Green }

        NuttyIceCream nuttyIceCream = new("Pistachio", "Green", "Pistachio");
        VeganIceCream veganIceCream = new("Pistachio", "Green", "Pistachio", new string[] { "Coconut Milk" });

        Console.WriteLine(nuttyIceCream);
        // NuttyIceCream { flavor = Pistachio, color = Green, seedType = Pistachio }
        Console.WriteLine(veganIceCream);
        // VeganIceCream { flavor = Pistachio, color = Green, seedType = Pistachio, Ingredients = System.String[] }

        NuttyIceCream nuttyIceCream2 = new("Pistachio", "Green", "Pistachio");

        bool isEqual = nuttyIceCream == nuttyIceCream2; // value based comparision
        Console.WriteLine(isEqual); // True


        // With the class example
        IceCream2 nuttyIceCream1 = new("Pistachio");
        IceCream2 nuttyIceCream12 = new("Pistachio");
        var c = nuttyIceCream1;

        Console.WriteLine(nuttyIceCream1 == nuttyIceCream12); // False
        Console.WriteLine(nuttyIceCream1 == c);  // True
    }
}