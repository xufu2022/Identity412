using Identity4121.Application.Decorators.AuditLog;
using Identity4121.Application.Decorators.DatabaseRetry;

namespace Identity4121.Application.Products.Queries
{
    public class GetProductsQuery : IQuery<List<Product>>
    {
    }

    [AuditLog]
    [DatabaseRetry]
    internal class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, List<Product>>
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public GetProductsQueryHandler(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> HandleAsync(GetProductsQuery query, CancellationToken cancellationToken = default)
        {
            return await _productRepository.ToListAsync(_productRepository.GetAll());
        }
    }
}
