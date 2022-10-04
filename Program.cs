using Microsoft.EntityFrameworkCore;
using team.BlueApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<WordsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WordsDB")));

var app = builder.Build();

app.MapControllers();

app.Run();