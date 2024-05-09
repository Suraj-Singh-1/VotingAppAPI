using Microsoft.EntityFrameworkCore;
using System;
using VotingAppAPI.Models;
using VotingAppAPI.Repository.IRepository;
using VotingAppAPI.Services;
using VotingAppAPI.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MyAppCs");
builder.Services.AddDbContext<VotingAppDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<ILoginService,LoginService>();
builder.Services.AddScoped<IAccountRepository, IAccountRepository>();

// Add services to the container.
//builder.Services.AddDbContext<Database>(options =>
//{
//    var config = builder.Configuration;
//    var connectionString = config.GetConnectionString("database");

//    options.UseSqlServer(connectionString);
//});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
