using EasyTest.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EasyTest.Data.Mappings
{
    public class BankInformationMap : EntityTypeConfiguration<BankInformation>
    {
        public BankInformationMap()
        {
            Property(x => x.Name).HasMaxLength(80);
            Property(x => x.Cpf).HasMaxLength(30);
            Property(x => x.Bank).HasMaxLength(30);
            Property(x => x.Agency).HasMaxLength(30);
            Property(x => x.AccountNumber).HasMaxLength(30);
            Property(x => x.OtherInformation).HasMaxLength(500);
        }
    }
}
