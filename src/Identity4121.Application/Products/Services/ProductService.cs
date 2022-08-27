namespace Identity4121.Application.Products.Services
{
    public class ProductService : CrudService<Product>, IProductService
    {
        public ProductService(IRepository<Product, Guid> productRepository, IDomainEvents domainEvents, ICurrentUser currentUser)
            : base(productRepository, domainEvents)
        {
        }
    }
}
