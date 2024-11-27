using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:80"); // Bind to all network interfaces


// Add services to the container.
builder.Services.AddControllers(); // Register controller services

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers(); // Map attribute-based controllers

app.Run();

// Define the HelloWorldController
[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, World!";
    }
}
