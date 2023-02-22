using business_logic;
using entity_layer;
using Microsoft.EntityFrameworkCore;
using ef = entity_layer.Entities;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var obj = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<ef.AssociatesDbContext>(options => options.UseSqlServer(obj));


builder.Services.AddScoped<Irepo, erepo>();
builder.Services.AddScoped<ILogic, Logic>();

builder.Services.AddScoped<IrepoSkill, RepoSkill>();
builder.Services.AddScoped<ILogic, Logic>();



builder.Services.AddScoped<IrepoCompany, repoCompany>();
builder.Services.AddScoped<ILogicCompany, LogicCompany>();

builder.Services.AddScoped<IrepoEducation, repoEducation>();
builder.Services.AddScoped<ILogicEducation, LogicEducation>();

builder.Services.AddCors(p => p.AddPolicy("cors", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("cors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
