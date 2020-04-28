using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RandomizerAPI.HubConfig;
using RandomizerAPI.Models;
using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.Context;
using RandomizerAPI.Models.DataManager;
using RandomizerAPI.Models.InfrastructureModels;
using RandomizerAPI.Models.Repository;
using System;

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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .WithOrigins("http://localhost:4200", "https://randomizer-dev.ilaena.net", "https://randomizerapi.ilaena.net"));
            });
            services.AddSignalR(hubOptions =>
            {
                hubOptions.EnableDetailedErrors = true;
                hubOptions.ClientTimeoutInterval = TimeSpan.FromMinutes(120);
                hubOptions.KeepAliveInterval = TimeSpan.FromSeconds(1);
                hubOptions.MaximumReceiveMessageSize = Int64.MaxValue;
            }
                ).AddJsonProtocol(options => {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null; });


            services.AddDbContext<RandomizerSessionContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:RandomizerDB"]));
            services.AddScoped<IDataRepository<RandomizerSession>, RandomizerManager>();
            services.AddScoped<IDataRepository<Error>, ErrorManager>();
            services.AddScoped<IDataRepository<Location>, LocationManager>();
            services.AddScoped<IDataRepository<Zone>, ZoneManager>();

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
