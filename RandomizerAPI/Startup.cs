using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models;
using RandomizerAPI.Models.Repository;
using RandomizerAPI.Models.DataManager;

namespace RandomizerAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(c =>
            //{
            //    //c.AddPolicy("CorsPolicy",
            //    //    builder => builder.AllowAnyOrigin()
            //    //    .AllowAnyMethod()
            //    //    .AllowAnyHeader());
            //    c.AddPolicy(name: MyAllowSpecificOrigins,
            //                  options =>
            //                      options
            //                      .WithOrigins("https://randomizerapi-dev.ilaena.net/",
            //                                          "https://randomizerapi.ilaena.net/",
            //                                          "https://localhost:4200/",
            //                                          "http://localhost:4200/",
            //                                          "https://localhost:44362/")
            //                      //.AllowAnyOrigin()
            //                      .AllowAnyMethod()
            //                      .AllowAnyHeader()
            //                      .AllowCredentials());
            //});
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .WithOrigins("http://localhost:4200", "https://randomizerapi-dev.ilaena.net/","https://randomizerapi.ilaena.net/")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            });
            services.AddSignalR(hubOptions =>
            { 
                hubOptions.ClientTimeoutInterval = TimeSpan.FromMinutes(120);
                hubOptions.KeepAliveInterval = TimeSpan.FromSeconds(1);
            }
                ).AddJsonProtocol(options => {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null; });

            services.AddDbContext<RandomizerSessionContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:RandomizerDB"]));
            services.AddScoped<IDataRepository<RandomizerSession>, RandomizerManager>();

            services.AddControllers(); 

            services.AddMvc(setupAction => {
                setupAction.EnableEndpointRouting = false;
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
            })
         .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SpoilerLogSessionHub>("/spoilerLogSession");
            });
        }
    }
}
