namespace Identity4121.Application.Common.Queries
{
    public class GetEntititesQuery<TEntity> : IQuery<List<TEntity>>
         where TEntity : AggregateRoot<Guid>
    {
    }

    internal class GetEntititesQueryHandler<TEntity> : IQueryHandler<GetEntititesQuery<TEntity>, List<TEntity>>
    where TEntity : AggregateRoot<Guid>
    {
        private readonly IRepository<TEntity, Guid> _repository;

        public GetEntititesQueryHandler(IRepository<TEntity, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<TEntity>> HandleAsync(GetEntititesQuery<TEntity> query, CancellationToken cancellationToken = default)
        {
            return await _repository.ToListAsync(_repository.GetAll());
        }
    }
}
