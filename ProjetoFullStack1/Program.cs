using Microsoft.EntityFrameworkCore;
using ProjetoFullStack1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<projetoGuriContext>(
    x=>x.UseSqlServer(builder.Configuration.GetConnectionString("connection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(option =>
    {
        option.AllowAnyHeader();
        option.AllowAnyMethod();
        option.AllowAnyOrigin();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
