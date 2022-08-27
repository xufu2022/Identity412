﻿using Identity4121.Infrastructure.HealthChecks;
using Identity4121.Infrastructure.Storages.Amazon;
using Identity4121.Infrastructure.Storages.Azure;
using Identity4121.Infrastructure.Storages.Fake;
using Identity4121.Infrastructure.Storages.Local;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Identity4121.Infrastructure.Storages
{
    public static class StoragesCollectionExtensions
    {
        public static IServiceCollection AddLocalStorageManager(this IServiceCollection services, LocalOptions options)
        {
            services.AddSingleton<IFileStorageManager>(new LocalFileStorageManager(options));

            return services;
        }

        public static IServiceCollection AddAzureBlobStorageManager(this IServiceCollection services, AzureBlobOption options)
        {
            services.AddSingleton<IFileStorageManager>(new AzureBlobStorageManager(options));

            return services;
        }

        public static IServiceCollection AddAmazonS3StorageManager(this IServiceCollection services, AmazonOptions options)
        {
            services.AddSingleton<IFileStorageManager>(new AmazonS3StorageManager(options));

            return services;
        }

        public static IServiceCollection AddFakeStorageManager(this IServiceCollection services)
        {
            services.AddSingleton<IFileStorageManager>(new FakeStorageManager());

            return services;
        }

        public static IServiceCollection AddStorageManager(this IServiceCollection services, StorageOptions options, IHealthChecksBuilder healthChecksBuilder = null)
        {
            if (options.UsedAzure())
            {
                services.AddAzureBlobStorageManager(options.Azure);

                if (healthChecksBuilder != null)
                {
                    healthChecksBuilder.AddAzureBlobStorage(
                        options.Azure,
                        name: "Storage (Azure Blob)",
                        failureStatus: HealthStatus.Degraded);
                }
            }
            else if (options.UsedAmazon())
            {
                services.AddAmazonS3StorageManager(options.Amazon);

                if (healthChecksBuilder != null)
                {
                    healthChecksBuilder.AddAmazonS3(
                    options.Amazon,
                    name: "Storage (Amazon S3)",
                    failureStatus: HealthStatus.Degraded);
                }
            }
            else if (options.UsedLocal())
            {
                services.AddLocalStorageManager(options.Local);

                if (healthChecksBuilder != null)
                {
                    healthChecksBuilder.AddLocalFile(new LocalFileHealthCheckOptions
                    {
                        Path = options.Local.Path,
                    },
                    name: "Storage (Local Directory)",
                    failureStatus: HealthStatus.Degraded);
                }
            }
            else
            {
                services.AddFakeStorageManager();
            }

            return services;
        }
    }
}