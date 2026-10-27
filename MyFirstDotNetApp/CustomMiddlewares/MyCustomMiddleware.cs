namespace MyFirstDotNetApp.CustomMiddlewares;
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("From main chain custom middleware 01\n");
            await next(context);
            await context.Response.WriteAsync("From main chain custom middleware 02\n");
        }
    }


public static class MyCustomMiddleWareExtension
{
    public static void UseMyCustomMiddleWare(this IApplicationBuilder app)
    {
        app.UseMiddleware<MyCustomMiddleware>();
    }
}
