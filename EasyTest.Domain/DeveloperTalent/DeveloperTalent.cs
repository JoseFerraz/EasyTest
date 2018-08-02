namespace EasyTest.Domain
{
    public class DeveloperTalent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string WhatsApp { get; set; }
        public string LinkedIn { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public virtual Knowledge Knowledge { get; set; }
        public string TestProjectLink { get; set; }
        public string PortfolioLink { get; set; }
        public virtual AdditionalInformation AdditionalInformation { get; set; }
        public virtual BankInformation BankInformation { get; set; }
    }
}
