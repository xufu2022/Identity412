using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Identity4121.Infrastructure.Web.Authorization.Policies
{
    public static class PolicyServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthorizationPolicies(this IServiceCollection services, Assembly assembly)
        {
            services.Configure<AuthorizationOptions>(options =>
            {
                var policyTypes = assembly.GetTypes().Where(t => t.GetInterfaces().Any(i => i == typeof(IPolicy))).ToList();

                foreach (var type in policyTypes)
                {
                    var obj = (IPolicy)Activator.CreateInstance(type);

                    var policyName = type.FullName;

                    options.AddPolicy(policyName, policy =>
                    {
                        obj.Configure(policy);
                    });
                }
            });

            var requirementHandlerTypes = assembly.GetTypes()
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(AuthorizationHandler<>))
                .ToList();

            foreach (var type in requirementHandlerTypes)
            {
                services.AddSingleton(typeof(IAuthorizationHandler), type);
            }

            return services;
        }
    }
}
