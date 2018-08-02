using EasyTest.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EasyTest.Data.Mappings
{
    public class KnowledgeMap : EntityTypeConfiguration<Knowledge>
    {
        public KnowledgeMap()
        {
            Property(x => x.Technologies.Ionic).IsRequired();
            Property(x => x.Technologies.Android).IsRequired();
            Property(x => x.Technologies.IOS).IsRequired();
            Property(x => x.Technologies.Bootstrap).IsRequired();
            Property(x => x.Technologies.JQuery).IsRequired();
            Property(x => x.Technologies.AngularJS).IsRequired();
            Property(x => x.Technologies.AspNetMvc).IsRequired();
            Property(x => x.Technologies.Php).IsRequired();
            Property(x => x.Technologies.Vue).IsRequired();
            Property(x => x.Technologies.WordPress).IsRequired();
            Property(x => x.Technologies.Other).HasMaxLength(500);
            Property(x => x.Languages.Other).HasMaxLength(500);
        }
    }
}
