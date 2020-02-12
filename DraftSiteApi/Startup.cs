using AutoMapper;
using DraftSiteApi.Hubs;
using DraftSiteModels.HubModels;
using DraftSiteModels.Maps;
using DraftSiteRepository;
using DraftSiteRepository.Interfaces;
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
using System;
using System.Threading.Tasks;

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

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.SlidingExpiration = true;
                    options.ExpireTimeSpan = TimeSpan.FromDays(7);
                });

            services.AddDbContext<DraftSiteContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(DraftSiteProfile));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDraftService, DraftService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDraftRepository, DraftRepository>();

            services.AddScoped<IUserMappingService<HubUser>, UserMappingService<HubUser>>();
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
                      .WithOrigins("http://draftsite.com", "http://localhost:8080");
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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<PreDraftLobbyHub>("/hubs/preDraftLobby");
            });
        }
    }
}
