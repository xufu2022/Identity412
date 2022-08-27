using Identity4121.Domain.Identity;
using System;

namespace Identity4121.BackgroundServer.Identity
{
    public class CurrentUser : ICurrentUser
    {
        public bool IsAuthenticated => false;

        public Guid UserId => Guid.Empty;
    }
}
