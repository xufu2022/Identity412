﻿namespace Identity4121.Domain.Repositories
{
    public class UserQueryOptions
    {
        public bool IncludeClaims { get; set; }
        public bool IncludeUserRoles { get; set; }
        public bool IncludeRoles { get; set; }
        public bool IncludeTokens { get; set; }
        public bool AsNoTracking { get; set; }
    }

    public interface IUserRepository : IRepository<User, Guid>
    {
        IQueryable<User> Get(UserQueryOptions queryOptions);
    }
}
