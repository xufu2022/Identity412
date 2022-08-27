using Identity4121.CrossCuttingConcerns.Tenants;

namespace Identity4121.Persistence
{
    public class AdsDbContextMultiTenant : AdsDbContext
    {
        private readonly IConnectionStringResolver<AdsDbContextMultiTenant> _connectionStringResolver;

        public AdsDbContextMultiTenant(
            IConnectionStringResolver<AdsDbContextMultiTenant> connectionStringResolver)
            : base(new DbContextOptions<AdsDbContext>())
        {
            _connectionStringResolver = connectionStringResolver;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStringResolver.ConnectionString);
        }
    }
}
