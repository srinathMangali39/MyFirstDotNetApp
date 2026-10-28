using MyFirstDotNetApp.CustomMiddlewares;
using System.Buffers;


var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)
//builder.Services.
//builder.Configuration
//builder.Environment
builder.Services.AddTransient<MyCustomMiddleware>();  // adding custom middleware to the services collection
//builder.Services.AddTransient<MyConventionalCustomMiddleWare>();


var app = builder.Build();   // instance of an web application 


// All about middleware 

//// middleware 1
//app.Use(async (HttpContext context,RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("Main chain Middleware 1\n");
//    await next(context);
//});


////app.UseMiddleware<MyCustomMiddleware>();

//app.UseMyCustomMiddleWare();  // using custom middleware using method extension

////app.UseMyConvenetionalCustomMiddleware();

//app.UseWhen((HttpContext context) =>
//{
//    return context.Request.Query.ContainsKey("userName");
//}, app =>
//{
//    // middleware branch
//    app.Use(async (HttpContext context, RequestDelegate next) =>
//    {
//        await context.Response.WriteAsync("From Middlerware branch \n");
//        await next(context);
//    });
//});

//// middleware 3
//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("Main chain Middleware 3\n");
//});




// Routing 


// end point middleware 1
// by default it accepts all http methods
// works coniditionally 
app.MapGet("/map1", async (context) =>
{
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("In Map get\n");
});


// end point middlware 2
// by default it accepts all http methods
app.MapPost("/map2", async (context) =>
{
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("In Map post\n");
});

app.MapFallback(async (context) =>
{
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("In Map fallback");
});



app.Run();


