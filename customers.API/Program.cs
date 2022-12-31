var builder = WebApplication.CreateBuilder(args);

// Compose services
ConfigureServices(builder.Services);

// Middleware

// Add services to WebApp container
// Configure the usage of common controllers
builder.Services.AddControllers();
// Configure ApiExplorer with Endpoint.Metadata
builder.Services.AddEndpointsApiExplorer();
// SwaggerDocument objects from routes
builder.Services.AddSwaggerGen();

// Build configuration of WebApplication
var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// DependencyInjection.IServiceCollection
void ConfigureServices(IServiceCollection services) // Contract spec for services
{
    // Add transient service IUsersService implemented as UsersService
    services.AddTransient<IUsersService, UsersService>();
}
