using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers;
using SendGrid.Helpers.Mail;

namespace Send_Mail
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }
        
        static async Task Execute()
        {
            var MyMail = Environment.GetEnvironmentVariable("MailFrom");
            var APIKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var Client = new SendGridClient(APIKey);
            var Mail_From = new EmailAddress(MyMail, "FromKoushik");
            var Mail_To = new EmailAddress(MyMail, "TOSomeOne");
            var Mail_Subject = "Official";
            var PlainTextContent = "Its easy to send the main to SendGrid";
            var HTMLContent = "<strong>Its easy to send the main to SendGrid</strong>";
            var Mail_Body = MailHelper.CreateSingleEmail(Mail_From, Mail_To, Mail_Subject, PlainTextContent, HTMLContent);

            var resoponse = await Client.SendEmailAsync(Mail_Body);
        }
    }
}