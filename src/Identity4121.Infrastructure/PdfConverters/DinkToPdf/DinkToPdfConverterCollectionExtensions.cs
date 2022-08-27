using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Identity4121.Infrastructure.PdfConverters.DinkToPdf
{
    public static class DinkToPdfConverterCollectionExtensions
    {
        public static IServiceCollection AddDinkToPdfConverter(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddSingleton<IPdfConverter, DinkToPdfConverter>();

            return services;
        }
    }
}
