using frutti.Server.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Exceptions;

var builder = Host.CreateApplicationBuilder();

var loggerConfiguration = new LoggerConfiguration()
                          .Enrich.FromLogContext()
                          .Enrich.WithExceptionDetails()
                          .WriteTo.Console();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(loggerConfiguration.CreateLogger());

builder.Services.AddHostedService<GameServerService>();

var host = builder.Build();
host.Run();
