using Core_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// API Controllers
builder.Services.AddControllers()
      .AddJsonOptions(options=> 
      {
          options.JsonSerializerOptions.PropertyNamingPolicy = null;
      });

//Regiser Services

builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped <ProductService> ();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle




// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



/// The Builder Model
/// // THE HTTP Pipeline
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
// USes Routing
app.MapControllers();

app.Run();
