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
//---------------------------------------------------------------------------------------------------------------------------------
// (!) Configure the "appsettings.json" file NOT HERE for "DefaultConnection" to the SQL server and git ignore any changes to it (!)
//---------------------------------------------------------------------------------------------------------------------------------
builder.Services.AddScoped<IAuthService>(provider =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    return new AuthService(connectionString);
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
