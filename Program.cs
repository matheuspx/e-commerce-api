using API_CRUD.DataAcess;
using API_CRUD.Services;
using API_CRUD.Services.Company;
using API_CRUD.Services.User;
using API_CRUD.Services.User.CreateUserUseCase;
using API_CRUD.Services.User.UserGetAllUseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserGetAll, UserGetAll>();

builder.Services.AddScoped<ICreateUser, CreateUser>();

builder.Services.AddScoped<IUserGetId, UserGetId>();

builder.Services.AddScoped<ICompanyService, CompanyService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ConnectionMySQL"),
        new MySqlServerVersion(new Version(8, 0, 32)) // Substitua pela versão do seu MySQL
    )
);

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