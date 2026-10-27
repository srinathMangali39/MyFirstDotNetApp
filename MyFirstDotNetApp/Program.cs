var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)
//builder.Services.
//builder.Configuration
//builder.Environment
var app = builder.Build();   // instance of an web application 


// Run() is actually a terminal middleware 

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello World");     // here this itself is the terminal middleware, it is the last middleware in the pipeline, so it will be executed at the end of the pipeline
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello World");
});

app.Run();  // runs the application in a server


