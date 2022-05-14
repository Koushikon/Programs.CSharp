using System;
using System.Net;
using System.Web;

namespace Class_Indexer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            cookie["name"] = "Billy";
            Console.Write("Nice weather: ");
            Console.WriteLine(cookie["name"]);

            cookie.setItem("name", "Joshi");
            Console.Write("Nice weather: ");
            Console.WriteLine(cookie.getItem("name"));
        }
    }
}
