using System.Reflection;
using Identity4121.Application.Common;
using Identity4121.Application.Common.Commands;
using Identity4121.Application.EmailMessages.Services;
using Identity4121.Application.EventLogs;
using Identity4121.Application.Products.Services;
using Identity4121.Application.SmsMessages.Services;
using Identity4121.Application.Users.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Identity4121.Application
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, Action<Type, Type, ServiceLifetime> configureInterceptor = null)
        {
            DomainEvents.RegisterHandlers(Assembly.GetExecutingAssembly(), services);

            services
                .AddScoped<IDomainEvents, DomainEvents>()
                .AddScoped(typeof(ICrudService<>), typeof(CrudService<>))
                .AddScoped<IUserService, UserService>()
                .AddScoped<IProductService, ProductService>()
                .AddScoped<EmailMessageService>()
                .AddScoped<SmsMessageService>()
                .AddScoped<PublishEventService>();

            if (configureInterceptor != null)
            {
                var aggregateRootTypes = typeof(AggregateRoot<>).Assembly.GetTypes().Where(x => x.BaseType == typeof(AggregateRoot<Guid>)).ToList();
                foreach (var type in aggregateRootTypes)
                {
                    configureInterceptor(typeof(ICrudService<>).MakeGenericType(type), typeof(CrudService<>).MakeGenericType(type), ServiceLifetime.Scoped);
                }

                configureInterceptor(typeof(IUserService), typeof(UserService), ServiceLifetime.Scoped);
                configureInterceptor(typeof(IProductService), typeof(ProductService), ServiceLifetime.Scoped);
            }

            return services;
        }

        public static IServiceCollection AddMessageHandlers(this IServiceCollection services)
        {
            services.AddScoped<Dispatcher>();

            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in assemblyTypes)
            {
                var handlerInterfaces = type.GetInterfaces()
                   .Where(Utils.IsHandlerInterface)
                   .ToList();

                if (!handlerInterfaces.Any())
                {
                    continue;
                }

                var handlerFactory = new HandlerFactory(type);
                foreach (var interfaceType in handlerInterfaces)
                {
                    services.AddTransient(interfaceType, provider => handlerFactory.Create(provider, interfaceType));
                }
            }

            var aggregateRootTypes = typeof(AggregateRoot<>).Assembly.GetTypes().Where(x => x.BaseType == typeof(AggregateRoot<Guid>)).ToList();

            var genericHandlerTypes = new[]
            {
                typeof(GetEntititesQueryHandler<>),
                typeof(GetEntityByIdQueryHandler<>),
                typeof(AddOrUpdateEntityCommandHandler<>),
                typeof(DeleteEntityCommandHandler<>),
            };

            foreach (var aggregateRootType in aggregateRootTypes)
            {
                foreach (var genericHandlerType in genericHandlerTypes)
                {
                    var handlerType = genericHandlerType.MakeGenericType(aggregateRootType);
                    var handlerInterfaces = handlerType.GetInterfaces();

                    var handlerFactory = new HandlerFactory(handlerType);
                    foreach (var interfaceType in handlerInterfaces)
                    {
                        services.AddTransient(interfaceType, provider => handlerFactory.Create(provider, interfaceType));
                    }
                }
            }

            return services;
        }
    }
}
