using Microsoft.AspNetCore.Authorization;

namespace Identity4121.Infrastructure.Web.Authorization.Policies
{
    public interface IPolicy
    {
        void Configure(AuthorizationPolicyBuilder policy);
    }
}
