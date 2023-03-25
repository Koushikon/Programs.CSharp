using HashidsNet;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Learn from Nick Chapsas

            var hashId = new Hashids("Asking");
            
            var eId = hashId.Encode(11);
            var eIds = hashId.Encode(11, 22, 33);

            Console.WriteLine($"Encoded Id: {eId}");
            Console.WriteLine($"Encoded Ids:  {eIds}");

            var dId = hashId.Decode(eId);
            var dIds = hashId.Decode(eIds);

            Console.WriteLine($"Encoded Id: {string.Join(", ", dId)}");
            Console.WriteLine($"Encoded Ids:  {string.Join(", ", dIds)}");
        }
    }
}