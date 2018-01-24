using System.Data.Entity.Infrastructure;

namespace DataMigSample.EF6
{
    public class MigDataContextFactory : IDbContextFactory<MigDataContext>
    {
        public MigDataContext Create()
        {
            return new MigDataContext("Server=.;Database=MigDataDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}