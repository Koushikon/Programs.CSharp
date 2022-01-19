using System;

namespace Switch_Statement
{
    class Program
    {
        public static void Main()
        {
            /**
             * * Taking User input 
             */
            Console.Write("Enter a month number: ");
            double season_num = double.Parse(Console.ReadLine());

            season_num = Math.Ceiling(season_num / 2) - 1;
            Season season = (Season)season_num;
            Console.WriteLine("Your Season number is: {0}", season_num);

            /**
             * * Pre-defined values
             */
            // Season season = Season.Late_Autumn;

            switch (season)
            {
                case Season.Summer:
                    Console.WriteLine("Its Summer Vacation time.");
                    break;
                case Season.Monsoon:
                    Console.WriteLine("Heavy rains are expected.");
                    break;
                case Season.Autumn:
                case Season.Late_Autumn:
                    Console.WriteLine("Durga Puja time.");
                    break;
                case Season.Winter:
                case Season.Spring:
                    {
                        Console.WriteLine("Its Cold out there.");
                        Console.WriteLine("Also Spring time.");
                    }
                    break;
                default:
                    Console.WriteLine("Do not know what to do.");
                    break;
            }
        }
    }
}