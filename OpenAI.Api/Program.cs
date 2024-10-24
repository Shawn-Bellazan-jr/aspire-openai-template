using Microsoft.OpenApi.Models;
using OpenAI.Api;
using OpenAI.Api.Interfaces;
using OpenAI.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();


// Add services to the container.
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<AIService>();

// Register Swagger services
builder.Services.AddEndpointsApiExplorer();  // Required for minimal APIs in .NET 6+
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "OpenAI API", Version = "v1" });
    options.SwaggerDoc("v2", new OpenApiInfo { Title = "OpenAI API v2", Version = "v2" });
});
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // Enable middleware to serve Swagger UI in development
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AspireApp API v1");
        c.RoutePrefix = string.Empty;  // Set Swagger UI to appear at the root
    });
}
app.MapControllers();
app.UseHttpsRedirection();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
