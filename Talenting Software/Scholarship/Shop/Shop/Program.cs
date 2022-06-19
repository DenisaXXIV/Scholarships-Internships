using Microsoft.EntityFrameworkCore;
using Shop.DAL.Interfaces;
using Shop.DAL.Migrations;
using Shop.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ShoppingDB;Trusted_Connection=True;MultipleActiveResultSets=true";

builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ShopDbContext>(ServiceLifetime.Transient);

#region Transient
builder.Services.AddScoped(typeof(IRepository<>), typeof(ShopRepository<>));
#endregion


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
