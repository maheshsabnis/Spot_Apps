using CategoryService.Models;
using CategoryService.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// REgister the DB Connection in DI

builder.Services.AddDbContext<EShoppingCodiContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConn"));
});

builder.Services.AddScoped<IRepoService<Category,int>, CategoryRepoService>();


// Add services to the container.
builder.Services.AddScoped<CategoryRepoService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
