using Discount.API;
using Discount.API.Extensions;

// var builder = WebApplication.CreateBuilder(args);
//
// var startup = new Startup(builder.Configuration);
// startup.ConfigureServices(builder.Services);
//
// var app = builder.Build();
// startup.Configure(app, builder.Environment);
//
// app.Run();

var host = CreateHostBuilder(args).Build();
host.MigrateDatabase<Program>();
host.Run();

 
 static IHostBuilder CreateHostBuilder(string[] args) => 
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });

    