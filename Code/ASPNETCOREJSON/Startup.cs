using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREJSON.Contexts;
using ASPNETCOREJSON.Models;
using ASPNETCOREJSON.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREJSON
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //Allow cross domain calls (our client asp web app in this case)
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });


            // Add framework services.
            services.AddMvc()
                    .AddJsonOptions(a => a.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());


            //using dependency injection


            //This is probably not secure here, but we let's go for it
            var connection = @"Server=tcp:lambda.database.windows.net,1433;Database=AirQualityV2;User ID=teamLambda;password=Twitter2016;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=AirQualityV2;Trusted_Connection=True;";

            services.AddDbContext<MercuriesContext>(
                options => options.UseSqlServer(connection));

            services.AddSingleton<IMercuriesRepository, MercuriesRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
