using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SurveyApi.Application;
using SurveyApi.Infrastructure;
using SurveyApi.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration();

builder.Services.AddDbContext<SurveyDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SurveyerDb"),
                                                                   options => options.MigrationsAssembly(Assembly.GetAssembly(typeof(SurveyDbContext))?.GetName().Name)));

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
