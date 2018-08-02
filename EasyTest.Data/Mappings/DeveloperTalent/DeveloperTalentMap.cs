using EasyTest.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EasyTest.Data.Mappings
{
    public class DeveloperTalentMap : EntityTypeConfiguration<DeveloperTalent>
    {
        public DeveloperTalentMap()
        {
            HasRequired(x => x.Knowledge);
            HasRequired(x => x.AdditionalInformation);
            HasOptional(x => x.BankInformation);

            Property(x => x.Name).HasMaxLength(80).IsRequired();
            Property(x => x.Email).HasMaxLength(80).IsRequired();
            Property(x => x.Skype).HasMaxLength(80).IsRequired();
            Property(x => x.WhatsApp).HasMaxLength(30).IsRequired();
            Property(x => x.LinkedIn).HasMaxLength(80);
            Property(x => x.State).HasMaxLength(80).IsRequired();
            Property(x => x.City).HasMaxLength(80).IsRequired();
            Property(x => x.TestProjectLink).HasMaxLength(80);
            Property(x => x.PortfolioLink).HasMaxLength(80);
        }
    }
}
