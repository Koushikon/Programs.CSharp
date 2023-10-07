using System;

namespace String_Between
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "This is an example string and my data is here";
            string data = getBetween(source, "an", "is");
            Console.WriteLine($"Data is: \"{data}\"");
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
    }
}
