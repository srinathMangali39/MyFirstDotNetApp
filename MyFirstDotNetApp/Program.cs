using MyFirstDotNetApp.CustomMiddlewares;
using System.Buffers;


var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)
//builder.Services.
//builder.Configuration
//builder.Environment
builder.Services.AddTransient<MyCustomMiddleware>();  // adding custom middleware to the services collection
builder.Services.AddTransient<MyConventionalCustomMiddleWare>();


var app = builder.Build();   // instance of an web application 


// middleware 1
app.Use(async (HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1\n");
    await next(context);
});


//app.UseMiddleware<MyCustomMiddleware>();

//app.UseMyCustomMiddleWare();  // using custom middleware using method extension

app.UseMyConvenetionalCustomMiddleware();

// middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Middleware 3");
});

app.Run();  // runs the application in a server


