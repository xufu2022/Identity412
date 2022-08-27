using Identity4121.Infrastructure.Monitoring.AppMetrics;
using Identity4121.Infrastructure.Monitoring.AzureApplicationInsights;
using Identity4121.Infrastructure.Monitoring.MiniProfiler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Identity4121.Infrastructure.Monitoring
{
    public static class MonitoringExtensions
    {
        public static IServiceCollection AddMonitoringServices(this IServiceCollection services, MonitoringOptions monitoringOptions = null)
        {
            if (monitoringOptions?.MiniProfiler?.IsEnabled ?? false)
            {
                services.AddMiniProfiler(monitoringOptions.MiniProfiler);
            }

            if (monitoringOptions?.AzureApplicationInsights?.IsEnabled ?? false)
            {
                services.AddAzureApplicationInsights(monitoringOptions.AzureApplicationInsights);
            }

            if (monitoringOptions?.AppMetrics?.IsEnabled ?? false)
            {
                services.AddAppMetrics(monitoringOptions.AppMetrics);
            }

            return services;
        }

        public static IMvcBuilder AddMonitoringServices(this IMvcBuilder mvcBuilder, MonitoringOptions monitoringOptions)
        {
            if (monitoringOptions?.AppMetrics?.IsEnabled ?? false)
            {
                mvcBuilder.AddMetrics();
            }

            return mvcBuilder;
        }

        public static IApplicationBuilder UseMonitoringServices(this IApplicationBuilder builder, MonitoringOptions monitoringOptions)
        {
            if (monitoringOptions?.MiniProfiler?.IsEnabled ?? false)
            {
                builder.UseMiniProfiler();
            }

            return builder;
        }
    }
}
