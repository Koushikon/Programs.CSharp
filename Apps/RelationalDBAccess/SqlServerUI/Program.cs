using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace SqlServerUI
{
    sealed class Program
    {
        static void Main()
        {
            SqlCRUD ObjDA = new(GetConnectionString());

            //ReadAllContacts(ObjDA);
            //ReadContact(ObjDA, 2);
            //CreateNewContact(ObjDA);
            //UpdateContact(ObjDA);
            //RemovePhoneNumber(ObjDA, 1005, 1003);

            Console.WriteLine(":: Learn From Tim Corey ::");
        }

        public static void CreateNewContact(SqlCRUD sql)
        {
            FullContact FC = new()
            {
                BasicInfo = new() { FirstName = "Debargo", LastName = "Bose" },
                EmailInfo = new() {
                    new Email { EmailAddress = "kishan@rediff.com" },
                    new Email { EmailAddress = "debargo@yahoo.com" }
                },
                PhoneInfo = new() {
                    new Phone { PhoneNumber = "1549569785" },
                    new Phone { PhoneNumber = "1597532584" }
                },
            };

            var returnId = sql.CreateContact(FC);
            ReadContact(sql, returnId);
        }

        private static void ReadContact(SqlCRUD sql, int contactId)
        {
            var contact = sql.GetFullContactsById(contactId);


            Console.WriteLine("::==========================================================::");
            Console.WriteLine($"Roll: {contact.BasicInfo.Id}, Full Name: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
            Console.WriteLine("Phone Numbers:");
            foreach (var item in contact.PhoneInfo)
            {
                Console.Write($"\tId: {item.Id}, Phone Number: {item.PhoneNumber}");
            }

            Console.WriteLine("\nEmails:");
            foreach (var item in contact.EmailInfo)
            {
                Console.Write($"\tId: {item.Id}, Email Address: {item.EmailAddress}");
            }
            Console.WriteLine("\n::==========================================================::");
        }

        private static void ReadAllContacts(SqlCRUD sql)
        {
            var dataObj = sql.GetAllContacts();

            foreach (var item in dataObj)
            {
                Console.WriteLine($"Roll: {item.Id}, Full Name: {item.FirstName} {item.LastName}");
            }
        }

        public static void UpdateContact(SqlCRUD sql)
        {
            BasicContact FC = new()
            {
                Id = 1005,
                FirstName = "Emily",
                LastName = "Sen"
            };

            var returnId = sql.UpdateContactName(FC);
            ReadContact(sql, returnId);
        }

        public static void RemovePhoneNumber(SqlCRUD sql, int contactId, int phoneId)
        {
            sql.RemovePhoneNumber(contactId, phoneId);
            ReadContact(sql, contactId);
        }

        private static string GetConnectionString(string ConnectionStringName = "Default")
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json");

            var config = builder.Build();

            string output = config.GetConnectionString(ConnectionStringName) ?? string.Empty;
            return output;
        }
    }
}