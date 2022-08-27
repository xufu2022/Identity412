namespace Identity4121.Domain
{
    public static class DomainServicesCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ProductService, ProductService>();
            return services;
        }
    }
}
