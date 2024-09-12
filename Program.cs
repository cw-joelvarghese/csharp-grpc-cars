using csharp_grpc_cars.BAL;
using csharp_grpc_cars.DAL;
using csharp_grpc_cars.Data;
using csharp_grpc_cars.Mappings;
using csharp_grpc_cars.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddGrpc();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddSingleton(new DatabaseConnection(connectionString!));
builder.Services.AddScoped<CarRepository>();
builder.Services.AddScoped<CarService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<FinService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
