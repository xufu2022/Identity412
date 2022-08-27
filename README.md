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
dotnet new webapp -o 'src\Identity4121.IdentityServer' 
dotnet new mvc -o 'src\Identity4121.WebMVC' 

dotnet new xunit -o 'tests\Identity4121.ArchTests' 
dotnet new xunit -o 'tests\Identity4121.ContractTests' 
dotnet new xunit -o 'tests\Identity4121.EndToEndTests' 
dotnet new xunit -o 'tests\Identity4121.IntegrationTests'
dotnet new xunit -o 'tests\Identity4121.UnitTests'

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
dotnet add 'src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj' --framework Microsoft.AspNetCore.App
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

# BackgroundServer
dotnet sln add 'src\Identity4121.BackgroundServer'  
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' package Microsoft.Extensions.Configuration.UserSecrets
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' package Microsoft.Extensions.Hosting.WindowsServices
dotnet add 'src\Identity4121.BackgroundServer\Identity4121.BackgroundServer.csproj' package StyleCop.Analyzers

# GraphQL
dotnet sln add 'src\Identity4121.GraphQL'  
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' package GraphQL
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' package GraphQL.Server.Transports.AspNetCore
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' package GraphQL.Server.Transports.AspNetCore.SystemTextJson
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' package GraphQL.Server.Ui.Playground
dotnet add 'src\Identity4121.GraphQL\Identity4121.GraphQL.csproj' package StyleCop.Analyzers

# Migrator
dotnet sln add 'src\Identity4121.Migrator'  
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' package dbup
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' package Polly
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' package Microsoft.EntityFrameworkCore.Tools
dotnet add 'src\Identity4121.Migrator\Identity4121.Migrator.csproj' package StyleCop.Analyzers

# WebAPI
dotnet sln add 'src\Identity4121.WebAPI'  
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' package Microsoft.AspNetCore.Mvc.Api.Analyzers
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add 'src\Identity4121.WebAPI\Identity4121.WebAPI.csproj' package StyleCop.Analyzers

# Blazor.Modules
dotnet sln add 'src\Identity4121.Blazor.Modules'  
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package IdentityModel
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package Microsoft.AspNetCore.Authentication
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package Microsoft.AspNetCore.Components
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package Microsoft.AspNetCore.Components.Authorization
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package Microsoft.AspNetCore.Components.Web
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package Microsoft.Extensions.Http
dotnet add 'src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj' package StyleCop.Analyzers

# BlazorServerSide
dotnet sln add 'src\Identity4121.BlazorServerSide'  
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' reference src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.AspNetCore.Authentication.OpenIdConnect
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.Azure.SignalR
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.Extensions.Logging.Debug
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.IdentityModel.Protocols.OpenIdConnect
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.VisualStudio.Azure.Containers.Tools.Targets
dotnet add 'src\Identity4121.BlazorServerSide\Identity4121.BlazorServerSide.csproj' package Microsoft.VisualStudio.Web.CodeGeneration.Design

# BlazorWebAssembly
dotnet sln add 'src\Identity4121.BlazorWebAssembly'  
dotnet add 'src\Identity4121.BlazorWebAssembly\Identity4121.BlazorWebAssembly.csproj' reference src\Identity4121.Blazor.Modules\Identity4121.Blazor.Modules.csproj
dotnet add 'src\Identity4121.BlazorWebAssembly\Identity4121.BlazorWebAssembly.csproj' package Microsoft.AspNetCore.Components.WebAssembly
dotnet add 'src\Identity4121.BlazorWebAssembly\Identity4121.BlazorWebAssembly.csproj' package Microsoft.AspNetCore.Components.WebAssembly.Authentication
dotnet add 'src\Identity4121.BlazorWebAssembly\Identity4121.BlazorWebAssembly.csproj' package Microsoft.AspNetCore.Components.WebAssembly.DevServer
dotnet add 'src\Identity4121.BlazorWebAssembly\Identity4121.BlazorWebAssembly.csproj' package System.Net.Http.Json

# IdentityServer
dotnet sln add 'src\Identity4121.IdentityServer'  
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package AutoMapper
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package IdentityServer4
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package Microsoft.AspNetCore.Authentication.Facebook
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package Microsoft.AspNetCore.Authentication.Google
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package Microsoft.AspNetCore.Authentication.MicrosoftAccount
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package Microsoft.AspNetCore.Identity.UI
dotnet add 'src\Identity4121.IdentityServer\Identity4121.IdentityServer.csproj' package StyleCop.Analyzers

# WebMVC
dotnet sln add 'src\Identity4121.WebMVC'  
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package AspNetCore.HealthChecks.UI.Client
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package AspNetCore.HealthChecks.UI.InMemory.Storage
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package IdentityModel
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.AspNetCore.Authentication.OpenIdConnect
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.Azure.SignalR
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.Extensions.Http
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.Extensions.Logging.Debug
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.IdentityModel.Protocols.OpenIdConnect
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add 'src\Identity4121.WebMVC\Identity4121.WebMVC.csproj' package StyleCop.Analyzers

# Tests
dotnet sln add 'tests\Identity4121.ArchTests'
dotnet add 'tests\Identity4121.ArchTests\Identity4121.ArchTests.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'tests\Identity4121.ArchTests\Identity4121.ArchTests.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj
dotnet add 'tests\Identity4121.ArchTests\Identity4121.ArchTests.csproj' reference src\Identity4121.Infrastructure\Identity4121.Infrastructure.csproj
dotnet add 'tests\Identity4121.ArchTests\Identity4121.ArchTests.csproj' reference src\Identity4121.Persistence\Identity4121.Persistence.csproj
dotnet add 'tests\Identity4121.ArchTests\Identity4121.ArchTests.csproj' reference src\Identity4121.WebAPI\Identity4121.WebAPI.csproj


dotnet sln add 'tests\Identity4121.ContractTests'
dotnet add 'tests\Identity4121.ContractTests\Identity4121.ContractTests.csproj' reference src\Identity4121.WebAPI\Identity4121.WebAPI.csproj


dotnet sln add 'tests\Identity4121.EndToEndTests'
dotnet add 'tests\Identity4121.EndToEndTests\Identity4121.EndToEndTests.csproj' package Microsoft.Extensions.Configuration
dotnet add 'tests\Identity4121.EndToEndTests\Identity4121.EndToEndTests.csproj' package Microsoft.Extensions.Configuration.Binder
dotnet add 'tests\Identity4121.EndToEndTests\Identity4121.EndToEndTests.csproj' package Microsoft.Extensions.Configuration.Json
dotnet add 'tests\Identity4121.EndToEndTests\Identity4121.EndToEndTests.csproj' package Selenium.WebDriver

 
dotnet sln add 'tests\Identity4121.IntegrationTests'
dotnet add 'tests\Identity4121.IntegrationTests\Identity4121.IntegrationTests.csproj' reference src\Identity4121.CrossCuttingConcerns\Identity4121.CrossCuttingConcerns.csproj
dotnet add 'tests\Identity4121.IntegrationTests\Identity4121.IntegrationTests.csproj' reference src\Identity4121.WebAPI\Identity4121.WebAPI.csproj

 
dotnet sln add 'tests\Identity4121.UnitTests'
dotnet add 'tests\Identity4121.UnitTests\Identity4121.UnitTests.csproj' reference src\Identity4121.Application\Identity4121.Application.csproj
dotnet add 'tests\Identity4121.UnitTests\Identity4121.UnitTests.csproj' reference src\Identity4121.Domain\Identity4121.Domain.csproj


# 'src\Identity4121.Infrastructure' 
# <FrameworkReference Include="Microsoft.AspNetCore.App" />