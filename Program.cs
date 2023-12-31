using Microsoft.EntityFrameworkCore;
using MoneyApp_Api.Models;
using MoneyApp_Api.Services;
using Pomelo.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var serverVersion = new MySqlServerVersion(new Version(8, 0, 10));

builder.Services.AddDbContext<railwayContext>(
    
    options => { options.UseMySql(DataHelper.GetStringDB(builder.Configuration),serverVersion);

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
