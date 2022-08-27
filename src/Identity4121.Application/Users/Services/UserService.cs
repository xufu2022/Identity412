namespace Identity4121.Application.Users.Services
{
    public class UserService : CrudService<User>, IUserService
    {
        public UserService(IRepository<User, Guid> userRepository, IDomainEvents domainEvents)
            : base(userRepository, domainEvents)
        {
        }
    }
}
