using FluentValidation;
using HeatCalc.Data;
using HeatCalc.Domain.Dto.Request;
using HeatCalc.Domain.Factories;
using HeatCalc.Domain.Interfaces;
using HeatCalc.Domain.Services;
using HeatCalcServer.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IValidator<BuildingRequest>, CreateBuildingRequestValidator>();
builder.Services.AddScoped<IValidator<BuildingRequest>, CreateBuildingWithParkingRequestValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IArchitectService, ArchitectService>();
builder.Services.AddSingleton<BuildingFactory>();
builder.Services.AddSingleton<BuildingResponseFactory>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HeatCalcConnectionString"));
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
