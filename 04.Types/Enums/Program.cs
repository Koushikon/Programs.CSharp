using System;

namespace Enums
{
    /**
     * * Similar type of the with enum declaration
     * * enum is internally mapped to the int type
     * * But we can define different types of the enum
     */

    public enum MailType
    {
        RegularAirMail = 1,
        PriorityAirMail = 2,
        ExpressAirMail = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Similar type of the with separate declaration
            const int RegularAirMail = 1;
            const int PriorityAirMail = 2;
            const int ExpressAirMail = 3;
            
            Console.WriteLine(RegularAirMail);
            Console.WriteLine(PriorityAirMail);
            Console.WriteLine(ExpressAirMail);

            Console.WriteLine(MailType.ExpressAirMail); // Shows the Name of the Enum
            Console.WriteLine((int)MailType.ExpressAirMail); // Shows the Value of the Enum

            /**
            * * Use it like this way
            * * Converting the integer to our corresponding enum
            */

            Console.WriteLine((MailType)3);

            var method1 = 3;
            Console.WriteLine((MailType)method1);

            /**
             * * Convert the enum value to an string
             */
            var method2 = MailType.PriorityAirMail;
            Console.WriteLine(method2.ToString());
            // By default Console.WriteLine() still converts the enum to string
            Console.WriteLine(method2);

            /**
             * * Parsing the string to the enum
             */

            var method3 = "ExpressAirMail";
            var result = (MailType)Enum.Parse(typeof(MailType), method3);

            Console.WriteLine(result);
        }
    }
}
