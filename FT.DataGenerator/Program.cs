using FT.Data.Team;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection.Extensions;
using FT.Data;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Get Configuration
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddITeamData(builder.Configuration);

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