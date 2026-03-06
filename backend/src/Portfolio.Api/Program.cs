using Portfolio.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
// builder.Services.AddOpenApi();

builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Portfolio API running");

app.Run();

public partial class Program { }