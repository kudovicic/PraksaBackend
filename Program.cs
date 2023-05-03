global using api_praksa.Controllers.Models;
using api_praksa.Services.PostService;
using api_praksa.Services.UserService;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PraksaProjekt.Context;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<DapperContext>();
builder.Services.AddControllers();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dodavanje interface
IServiceCollection serviceCollection = builder.Services.AddScoped<IPostService,PostService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();






app.Run();

