using Microsoft.Extensions.DependencyInjection;
using RazorLight;

namespace Identity4121.Infrastructure.HtmlGenerators
{
    public static class HtmlGeneratorCollectionExtensions
    {
        public static IServiceCollection AddHtmlGenerator(this IServiceCollection services)
        {
            var engine = new RazorLightEngineBuilder()
                   .UseFileSystemProject(Environment.CurrentDirectory)
                   .UseMemoryCachingProvider()
                   .Build();

            services.AddSingleton<IRazorLightEngine>(engine);
            services.AddSingleton<IHtmlGenerator, HtmlGenerator>();

            return services;
        }
    }
}
