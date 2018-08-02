namespace EasyTest.Domain
{
    public class BankInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Bank { get; set; }
        public string Agency { get; set; }
        public bool ChainAccount { get; set; }
        public bool SavingsAccount { get; set; }
        public string AccountNumber { get; set; }
        public string OtherInformation { get; set; }
    }
}
