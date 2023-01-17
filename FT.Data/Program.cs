using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Serilog;

using FT.Data;
using FT.Objects;
using FT.ServiceCollectionExtensions;
using FT.Data.Team;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Get Configuration
var config = builder.Configuration;

//Bind configuration to structured class
var appSettings = config.Get<AppSettings>();
//Add Structured AppSettings to services
builder.Services.AddSingleton<AppSettings>(appSettings);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAllLocalServices(appSettings);

// Use Serilog
builder.Host.UseSerilog((hostContext, services, configuration) => {
    configuration
        .MinimumLevel.Is(Enum.Parse<Serilog.Events.LogEventLevel>(config.GetValue<string>("Logging:LogLevel:Default")))
        .WriteTo.File("Data.log")
        .WriteTo.Console();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();