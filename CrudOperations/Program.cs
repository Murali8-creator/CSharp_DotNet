using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Repository;
using CrudOperations.Service;
using CrudOperations.Service.command;
using CrudOperations.Service.Query;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BrandContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BrandCS")));


// Add services to the container.
builder.Services.AddScoped<ICommandHandler<AddBrandCommand>, AddBrandHandler>();
builder.Services.AddScoped<IQueryHandler<GetBrandQuery, List<BrandDTO>> ,GetBrandHandler>();
builder.Services.AddScoped<IQueryHandler<GetBrandQuery,Brand> ,GetBrandByIdHandler>();
builder.Services.AddScoped<ICommandHandler<PutBrandCommand>, PutBrandHandler>();
builder.Services.AddScoped<ICommandHandler<DeleteBrandCommand>, DeleteBrandHandler>();
builder.Services.AddScoped<ICommandHandler<AddUserCommand>, AddUserHandler>();
builder.Services.AddScoped<IQueryHandler<GetUserQuery, List<UserDTO>>, GetUserHandler>();

builder.Services.AddScoped <IQueryHandler<GetUserQuery, UserDTO>, GetUserByIdHandler>();


//add repositories
builder.Services.AddScoped<UsersRepository, UsersRepositoryImpl>();
builder.Services.AddScoped<BrandRepository, BrandRepositoryImpl>();



builder.Services.AddControllers().AddJsonOptions(options =>
{
    //options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

}); ;


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

app.UseAuthorization();

app.MapControllers();

app.Run();
