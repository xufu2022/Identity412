using Identity4121.Application;
using Identity4121.Application.FileEntries.DTOs;
using Identity4121.BackgroundServer;
using Identity4121.BackgroundServer.ConfigurationOptions;
using Identity4121.BackgroundServer.HostedServices;
using Identity4121.BackgroundServer.Identity;
using Identity4121.Domain;
using Identity4121.Domain.Identity;
using Identity4121.Infrastructure.Logging;
using Identity4121.Infrastructure.MessageBrokers;
using Identity4121.Infrastructure.Notification;
using Identity4121.Infrastructure.Notification.Web;
using Identity4121.Infrastructure.OS;
using Identity4121.Persistence;
using Identity4121.BackgroundServer;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .UseClassifiedAdsLogger(configuration =>
    {
        var appSettings = new AppSettings();
        configuration.Bind(appSettings);
        return appSettings.Logging;
    })
    .ConfigureServices((hostContext, services) =>
    {
        var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetService<IConfiguration>();

        var appSettings = new AppSettings();
        configuration.Bind(appSettings);

        var validationResult = appSettings.Validate();
        if (validationResult.Failed)
        {
            throw new Exception(validationResult.FailureMessage);
        }

        services.Configure<AppSettings>(configuration);

        services.AddScoped<ICurrentUser, CurrentUser>();

        services.AddDateTimeProvider();
        services.AddPersistence(appSettings.ConnectionStrings.ClassifiedAds)
            .AddDomainServices()
            .AddApplicationServices();

        services.AddMessageBusSender<FileUploadedEvent>(appSettings.MessageBroker);
        services.AddMessageBusSender<FileDeletedEvent>(appSettings.MessageBroker);

        services.AddMessageBusReceiver<FileUploadedEvent>(appSettings.MessageBroker);
        services.AddMessageBusReceiver<FileDeletedEvent>(appSettings.MessageBroker);

        services.AddNotificationServices(appSettings.Notification);

        services.AddWebNotification<SendTaskStatusMessage>(appSettings.Notification.Web);

        services.AddHostedService<MessageBusReceiver>();
        services.AddHostedService<PublishEventWorker>();
        services.AddHostedService<SendEmailWorker>();
        services.AddHostedService<SendSmsWorker>();
        services.AddHostedService<ScheduleCronJobWorker>();
    })
    .Build();

await host.RunAsync();