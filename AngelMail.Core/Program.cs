using AngelMail.Core.Data;
using Core.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CoreDbContext>(
    o => o.UseSqlite(builder.Configuration.GetConnectionString("SqLite")));

var app = builder.Build();

app.MapControllers();

app.Run();