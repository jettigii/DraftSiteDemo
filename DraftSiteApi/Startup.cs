using AutoMapper;
using DraftSiteApi.Hubs;
using DraftSiteModels.Maps;
using DraftSiteRepository.Interfaces;
using DraftSiteRepository.Models;
using DraftSiteRepository.Repositories;
using DraftSiteService.Interfaces;
using DraftSiteService.Services;
using FiniTechSolutions.Interfaces;
using FiniTechSolutions.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace DraftSiteApi
{
    public class Startup
    {
        public const string VUE_CORS_POLICY = "VueCorsPolicy";

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSignalR();

            services.AddDbContext<DraftSiteContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                        mySqlOptions =>
                        {
                            mySqlOptions.ServerVersion(new Version(5, 7, 17), ServerType.MySql)
                            .EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                        });
            });

            services.AddAutoMapper(typeof(DraftSiteProfile));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDraftService, DraftService>();
            services.AddScoped<IUserLobbyMappingService, UserLobbyMappingService>();
            services.AddScoped<IDraftComputerPlayerService, DraftComputerPlayerService>();
            services.AddScoped<IMultiPlayerDraftService, MultiPlayerDraftService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDraftRepository, DraftRepository>();

            services.AddScoped<IPasswordService, PasswordService>();

            services.AddCors(options =>
            {
                options.AddPolicy(VUE_CORS_POLICY, builder =>
                {
                    builder
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowCredentials()
                      // Todo Make configurable
                      .WithOrigins("http://draftsite.com", "http://localhost:8080", "http://finitech-001-site4.gtempurl.com");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseCors(VUE_CORS_POLICY);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<DraftLobbyHub>("/hubs/draftLobby");
                endpoints.MapHub<MultiPlayerDraftHub>("/hubs/multiplayerDraftLobby");
                endpoints.MapHub<PreDraftLobbyHub>("/hubs/preDraftLobby");
            });
        }
    }
}
