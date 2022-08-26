# Identity412

dotnet new sln --name Identity4121 
# dotnet new webapi -n ProjectName -f net6.0
dotnet new globaljson --sdk-version 6.0.303 --force
dotnet new classlib -o 'src\Identity4121.Application' 
dotnet new classlib -o 'src\Identity4121.Domain' 
dotnet new classlib -o 'src\Identity4121.CrossCuttingConcerns' 
dotnet new classlib -o 'src\Identity4121.Infrastructure' 
dotnet new classlib -o 'src\Identity4121.Persistence' 
dotnet new worker -o 'src\Identity4121.BackgroundServer' 
dotnet new webapi -o 'src\Identity4121.GraphQL' 
dotnet new webapi -o 'src\Identity4121.Migrator' 
dotnet new webapi -o 'src\Identity4121.WebAPI' 
dotnet new classlib -o 'src\Identity4121.Blazor.Modules' 
dotnet new blazorserver -o 'src\Identity4121.BlazorServerSide' 
dotnet new blazorwasm -o 'src\Identity4121.BlazorWebAssembly' 
dotnet new page -o 'src\Identity4121.IdentityServer' 
dotnet new mvc -o 'src\Identity4121.WebMVC' 

# CrossCuttingConcerns
dotnet sln add 'src\Identity4121.CrossCuttingConcerns'
dotnet add 'src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj' package StyleCop.Analyzers
dotnet add 'src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj' package System.Text.Json


# Application
dotnet sln add 'src\Identity4121.Application'  
dotnet add 'src\Identity4121.Application\Identity4121.Application.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.Application\Identity4121.Application.csproj' package Microsoft.Extensions.Configuration.Abstractions
dotnet add 'src\Identity4121.Application\Identity4121.Application.csproj' package Microsoft.Extensions.Logging.Abstractions
dotnet add 'src\Identity4121.Application\Identity4121.Application.csproj' package StyleCop.Analyzers


# Domain
dotnet sln add 'src\Identity4121.Domain'  
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' package Microsoft.Extensions.Configuration.Abstractions
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' package System.ComponentModel.Annotations
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' package Microsoft.CSharp -Version 4.7.0
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' package System.Text.Json
dotnet add 'src\Identity4121.Domain\Identity4121.Domain.csproj' package StyleCop.Analyzers

# Persistence
dotnet sln add 'src\Identity4121.Persistence'  
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package EntityFrameworkCore.SqlServer.SimpleBulks
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package IdentityServer4
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package IdentityServer4.AspNetIdentity
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package IdentityServer4.EntityFramework
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package Microsoft.AspNetCore.DataProtection.EntityFrameworkCore
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package Microsoft.AspNetCore.Http.Abstractions
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package IdentityServer4.EntityFramework
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package Microsoft.EntityFrameworkCore
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package Microsoft.EntityFrameworkCore.SqlServer
dotnet add 'src\Identity4121.Persistence\Identity4121.Persistence.csproj' package StyleCop.Analyzers


# Infrastructure
dotnet sln add 'src\Identity4121.Infrastructure'  
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.AspNetCore.App
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package App.Metrics
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package App.Metrics.Formatters.Prometheus
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package App.Metrics.AspNetCore.Mvc
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package App.Metrics.AspNetCore.Tracking
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package AspNetCore.HealthChecks.UI
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package AWSSDK.S3
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Communication.Sms
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Data.AppConfiguration
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Extensions.AspNetCore.Configuration.Secrets
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Identity
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Messaging.EventGrid
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Messaging.EventHubs
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Messaging.EventHubs.Processor
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Messaging.ServiceBus
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Storage.Blobs
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Azure.Storage.Queues
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Castle.Core
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package ClosedXML
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Confluent.Kafka
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package CryptographyHelper
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package CsvHelper
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Dapper.StrongName
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package DinkToPdf
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package EPPlus
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package ExcelDataReader
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package IdentityModel
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.ApplicationInsights.AspNetCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.AspNetCore.Authentication.OpenIdConnect
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.AspNetCore.SignalR.Client
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.AspNetCore.SignalR.Protocols.MessagePack
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Azure.AppConfiguration.AspNetCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.EntityFrameworkCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Extensions.Caching.Redis
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Extensions.Caching.SqlServer
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Extensions.Logging.Abstractions
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Extensions.Logging.AzureAppServices
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Microsoft.Extensions.Logging.EventLog
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package MiniProfiler.AspNetCore.Mvc
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package MiniProfiler.EntityFrameworkCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package MiniProfiler.Providers.SqlServer
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package RabbitMQ.Client
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package RazorLight
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package SendGrid
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Serilog
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Serilog.AspNetCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Serilog.Enrichers.Environment
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Serilog.Exceptions
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Serilog.Sinks.Elasticsearch
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package StyleCop.Analyzers
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package System.Data.SqlClient
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Twilio
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Exporter.Jaeger
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Exporter.OpenTelemetryProtocol
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Exporter.Zipkin
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Extensions.Hosting
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Instrumentation.AspNetCore
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package OpenTelemetry.Instrumentation.Http
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package PuppeteerSharp
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' package Quartz
