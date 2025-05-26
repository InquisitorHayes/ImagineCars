using ImagineCars.Data;
using ImagineCars.Data.Repositories;
using ImagineCars.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IWorkshopRepository, WorkshopRepository>();

builder.Services.AddPooledDbContextFactory<ImagineCarsDbContext>((sp, options) =>
{
    var connectionStringBuilder = new NpgsqlConnectionStringBuilder()
    {
        Host = "localhost", // assuming you're running the docker compose up :) 
        Username = "postgres",
        Password = "postgres",
        Database = "ImagineCars",
        Port = 5432
    };
    options.UseNpgsql(connectionStringBuilder.ConnectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();