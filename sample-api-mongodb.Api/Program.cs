using sample_api_mongodb.Infrastructure;
using sample_api_mongodb.Core;
using sample_api_mongodb.Core.Commons;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using sample_api_mongodb.Core.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Retrieve client URL and CORS policy name from configuration
var clientUrl = builder.Configuration[Constants.AppSettings.Client_URL]?.ToString();
var cors = builder.Configuration[Constants.AppSettings.CorsPolicy]?.ToString();

// Inject dependencies and configurations
builder.Services.InjectInfraConfig(builder.Configuration);
builder.Services.InjectJWTConfig(builder.Configuration);
builder.Services.InjectServices();

// Configure CORS to allow specific origins
builder.Services.AddCors(options =>
{
    options.AddPolicy(cors!, policyBuilder =>
    {
        policyBuilder.WithOrigins(clientUrl!)
                     .AllowAnyMethod()
                     .AllowAnyHeader();
    });
});

// Add Exception Middleware, Controllers, and Swagger services
builder.Services.AddTransient<ExceptionMiddleware>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Configure Swagger with security definitions
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

var app = builder.Build();

// Enable Swagger only in development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use configured CORS policy
app.UseCors(cors!);

// Use HTTPS redirection
app.UseHttpsRedirection();

// Use Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Configure custom exception middleware
app.ConfigureExceptionMiddleware();

// Map controllers to endpoints
app.MapControllers();

app.Run();
