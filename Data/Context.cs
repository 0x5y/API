using System.Data.Entity;
using API.Data.Models;
using Bot.Data;

namespace API.Data
{
    [DbConfigurationType(typeof (CodeConfig))]
    public class DataBaseContext : DbContext
    {
        public DbSet<Rebirth> Rebirths { get; set; }
        public DbSet<Sacrifice> Sacrifices { get; set; }
        public DbSet<Enchant> Enchants { get; set; }
        public DbSet<Forge> Forges { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<User> Users { get; set; }

        public DataBaseContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.SetInitializer<DataBaseContext>(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
    }

    public class CodeConfig : DbConfiguration
    {
        public CodeConfig()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}