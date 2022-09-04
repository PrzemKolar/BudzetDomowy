using BudzetDomowy.ApplicationServices.API.Domain;
using BudzetDomowy.ApplicationServices.API.Mappings;
using BudzetDomowy.DataAccess;
using BudzetDomowy.DataAccess.CQRS;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HouseholdBudgetStorageContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("HouseholdBudgetDatabaseConnection")));
builder.Services.AddMediatR(typeof(ResponseBase<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(typeof(ShopsProfile).Assembly);
builder.Services.AddTransient<IQueryExecutor, QueryExecutor>();
builder.Services.AddTransient<ICommandExecutor, CommandExecutor>();

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
