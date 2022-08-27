using System.Configuration;
using System.Reflection;
using DbUp;
using Identity4121.Infrastructure.HealthChecks;
using Identity4121.Infrastructure.OS;
using Identity4121.Migrator;
using Identity4121.Persistence;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Polly;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
if (string.Equals(configuration["CheckDependency:Enabled"], "true", System.StringComparison.OrdinalIgnoreCase))
{
    NetworkPortCheck.Wait(configuration["CheckDependency:Host"], 5);
}
builder.Services.AddDateTimeProvider();

builder.Services.AddPersistence(configuration["ConnectionStrings:ClassifiedAds"],
    typeof(WeatherForecast).GetTypeInfo().Assembly.GetName().Name);

builder.Services.AddIdentityServer()
    .AddIdServerPersistence(configuration.GetConnectionString("ClassifiedAds"),
        typeof(WeatherForecast).GetTypeInfo().Assembly.GetName().Name);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

Policy.Handle<Exception>().WaitAndRetry(new[]
    {
        TimeSpan.FromSeconds(10),
        TimeSpan.FromSeconds(20),
        TimeSpan.FromSeconds(30),
    })
    .Execute(() =>
    {
        app.MigrateAdsDb();
        app.MigrateIdServerDb();

        var upgrader = DeployChanges.To
            .SqlDatabase(configuration.GetConnectionString("ClassifiedAds"))
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .LogToConsole()
            .Build();

        var result = upgrader.PerformUpgrade();

        if (!result.Successful)
        {
            throw result.Error;
        }
    });
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
