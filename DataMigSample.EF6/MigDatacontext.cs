using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataMigSample.EF6.Models;

namespace DataMigSample.EF6
{
    public class MigDataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public MigDataContext(string connString)
            : base(connString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}