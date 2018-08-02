using EasyTest.Data.Mappings;
using EasyTest.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EasyTest.Data.DataContexts
{
    public class DevelopersTalentsDataContext : DbContext
    {
        public DevelopersTalentsDataContext() : base("DevelopersTalentsConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new DeveloperTalentMap());
            modelBuilder.Configurations.Add(new KnowledgeMap());
            modelBuilder.Configurations.Add(new AdditionalInformationMap());
            modelBuilder.Configurations.Add(new BankInformationMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DeveloperTalent> DeveloperTalent { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<AdditionalInformation> AdditionalInformation { get; set; }
        public DbSet<BankInformation> BankInformation { get; set; }
    }
}
