using Microsoft.Extensions.DependencyInjection;
using PuppeteerSharp;

namespace Identity4121.Infrastructure.PdfConverters.PuppeteerSharp
{
    public static class PuppeteerSharpConverterCollectionExtensions
    {
        public static IServiceCollection AddPuppeteerSharpPdfConverter(this IServiceCollection services)
        {
            var browserFetcher = new BrowserFetcher();
            browserFetcher.DownloadAsync().GetAwaiter().GetResult();

            services.AddSingleton<IPdfConverter, PuppeteerSharpConverter>();

            return services;
        }
    }
}
