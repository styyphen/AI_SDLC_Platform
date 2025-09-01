using AI_SDLC_Platform.Agents;
using AI_SDLC_Platform.Core.Agents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Add CORS with explicit handling for preflight requests
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.WithOrigins("http://localhost:5000")
            .AllowAnyMethod() // Explicitly allow POST, OPTIONS, etc.
            .AllowAnyHeader()
            .SetPreflightMaxAge(TimeSpan.FromSeconds(86400));
    });
});

// Register agents
builder.Services.AddSingleton<IAgent, ClaudeAgent>();
builder.Services.AddSingleton<IAgent, DeepSeekAgent>();
builder.Services.AddSingleton<IAgent, CopilotAgent>();
builder.Services.AddSingleton<IAgent, GrokAgent>();
builder.Services.AddSingleton<IAgent, GeminiAgent>();

var app = builder.Build();

// Enable detailed logging for diagnostics
app.UseDeveloperExceptionPage(); // For development only
// Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Apply CORS before routing
app.UseCors("AllowBlazorClient");

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

// Log discovered controllers for debugging
app.Lifetime.ApplicationStarted.Register(() =>
{
    var controllerTypes = app.Services.GetRequiredService<IControllerActivator>()
        .GetType().Assembly.GetTypes()
        .Where(t => typeof(ControllerBase).IsAssignableFrom(t));
    Console.WriteLine("Discovered controllers: " + string.Join(", ", controllerTypes.Select(t => t.FullName)));
});

app.Run();