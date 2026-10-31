using MyFirstDotNetApp.Controllers;
using MyFirstDotNetApp.CustomContraints;
using MyFirstDotNetApp.CustomMiddlewares;
using System.Buffers;


var builder = WebApplication.CreateBuilder(args);  // builder loads configurations ( connection strings etc), environments ( Api urls or sever names), default services (Predefiend and userdefined services)

builder.Services.AddTransient<HomeController>(); // register HomeController as a transient service in the DI container

builder.Services.AddControllers();  // register the controllers in the DI container, same as above , but for all controllers in the project

var app = builder.Build(); // build the application and create a web host

app.MapControllers(); // map the controllers to the request pipeline



app.Run();


