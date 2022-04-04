using Microsoft.EntityFrameworkCore;
using TargetInvestimentos.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var DATABASE_HOST = Environment.GetEnvironmentVariable("DATABASE_HOST");
var DATABASE_PASSWORD = Environment.GetEnvironmentVariable("DATABASE_PASSWORD");

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer($"Server={DATABASE_HOST};Database=app;Trusted_Connection=True;Password={DATABASE_PASSWORD}");
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
