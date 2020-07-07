using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            // Hong
            //using (var scope = host.Services.CreateScope())
            //{
            //    var serviceProvider = scope.ServiceProvider;
            //    var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>());

            //    try
            //    {
            //        SeedData.Initialize(context);
            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "An error occurred seeding the DB.");
            //    }
            //}

            host.Run();
        }

        /******************************************************************************************/


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        /******************************************************************************************/
        // Configure services without Startup

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingContext, config) => { })
        //   .ConfigureWebHostDefaults(webBuilder =>
        //   {
        //       webBuilder.ConfigureServices(services =>
        //       {
        //           services.AddControllersWithViews();
        //       })
        //       .Configure(app =>
        //       {
        //           var loggerFactory = app.ApplicationServices.GetRequiredService<ILoggerFactory>();
        //           var logger = loggerFactory.CreateLogger<Program>();
        //           var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
        //           var config = app.ApplicationServices.GetRequiredService<IConfiguration>();

        //           logger.LogInformation("Logged in Configure");

        //           if (env.IsDevelopment())
        //           {
        //               app.UseDeveloperExceptionPage();
        //           }
        //           else
        //           {
        //               app.UseExceptionHandler("/Home/Error");
        //               app.UseHsts();
        //           }

        //           var configValue = config["MyConfigKey"];
        //       });
        //   });

        /******************************************************************************************/
    }
}
