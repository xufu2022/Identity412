namespace Identity4121.CrossCuttingConcerns.Tenants
{
    public interface IConnectionStringResolver<TDbContext>
    {
        string ConnectionString { get; }

        string MigrationsAssembly { get; }
    }
}
