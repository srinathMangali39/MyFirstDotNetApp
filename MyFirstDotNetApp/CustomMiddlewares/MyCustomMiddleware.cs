namespace MyFirstDotNetApp.CustomMiddlewares;
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("From custom middleware 01");
            await next(context);
            await context.Response.WriteAsync("From custom middleware 02");
        }
    }


public static class MyCustomMiddleWareExtension
{
    public static void UseMyCustomMiddleWare(this IApplicationBuilder app)
    {
        app.UseMiddleware<MyCustomMiddleware>();
    }
}
