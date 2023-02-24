namespace DataAccessLibrary.Models
{
    public class FullContact
    {
        public BasicContact BasicInfo { get; set; } = new BasicContact();
        public List<Email> EmailInfo { get; set; } = new List<Email>();
        public List<Phone> PhoneInfo { get; set; } = new List<Phone>();
    }
}
