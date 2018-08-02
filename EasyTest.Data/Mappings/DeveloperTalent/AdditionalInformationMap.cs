using EasyTest.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EasyTest.Data.Mappings
{
    public class AdditionalInformationMap : EntityTypeConfiguration<AdditionalInformation>
    {
        public AdditionalInformationMap()
        {
            Property(x => x.HourlySalaryPretension).HasMaxLength(20).IsRequired();
        }
    }
}
