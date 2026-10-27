using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyFirstDotNetApp.CustomMiddlewares;

// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
public class MyConventionalCustomMiddleWare
{
    private readonly RequestDelegate _next;

    public MyConventionalCustomMiddleWare(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        if(httpContext.Request.Query.ContainsKey("firstName") && httpContext.Request.Query.ContainsKey("lastName"))
        {
            string fullName = httpContext.Request.Query["firstName"] + " " + httpContext.Request.Query["lastName"];
            await httpContext.Response.WriteAsync(fullName + "\n");
        }
        await _next(httpContext);
    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseMyConvenetionalCustomMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MyConventionalCustomMiddleWare>();
    }
}

