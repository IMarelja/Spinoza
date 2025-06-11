using Microsoft.EntityFrameworkCore;
using MiddleWareSimulation.Services;

var builder = WebApplication.CreateBuilder(args);

// Install those packages
//
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.5
// dotnet add package Microsoft.EntityFrameworkCore
//


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Edit this file depending on the service
builder.Services.AddScoped<IAuthService>(provider =>
    new AuthService("Server=IM-SCHOOL-T460S;Database=Spinoza;User Id=sas;Password=SQL;TrustServerCertificate=true;"));


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
