var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)
//builder.Services.
//builder.Configuration
//builder.Environment
var app = builder.Build();   // instance of an web application 


// middleware 1
app.Use(async (HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello World");
    await next(context);
});

// middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello World Again 01 ");
    await next(context);
});


// middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello World Again 02 ");
});

app.Run();  // runs the application in a server


