var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)
//builder.Services.
//builder.Configuration
//builder.Environment
var app = builder.Build();   // instance of an web application 

// app helps to configure middlewares 

// app.MapGet("/", () => "Hello World!");


app.Run(async (HttpContext context) =>
{
    // Request 
    string path = context.Request.Path;
    string method = context.Request.Method;
    context.Request.Query.ContainsKey("id");   //  Localhost::8989/api/request/id?=1
    string? id = context.Request.Query["id"];
    // context.Request.Headers;  it is a dictionary

    // Responses
    context.Response.StatusCode = 400;
    context.Response.Headers["key"] = "Value";  // user defined 
    context.Response.Headers["Server"] = "My server"; // overriding the exisinting header server name 
    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync("World");
});

app.Run();  // runs the application in a server



// profile in launchSettings.json  - collection of settings enable server when running the application