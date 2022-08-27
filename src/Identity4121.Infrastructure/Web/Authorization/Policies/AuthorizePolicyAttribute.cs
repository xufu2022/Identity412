using Microsoft.AspNetCore.Authorization;

namespace Identity4121.Infrastructure.Web.Authorization.Policies
{
    public class AuthorizePolicyAttribute : AuthorizeAttribute
    {
        public AuthorizePolicyAttribute(Type policy)
            : base(policy.FullName)
        {
        }
    }
}
