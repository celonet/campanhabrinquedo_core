using System;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using campanhabrinquedo.repository;
using campanhabrinquedo.webapi.Extensions;
using campanhabrinquedo.webapi.Model;
using campanhabrinquedo.repository.Configurations;
using campanhabrinquedo.ioc;

namespace campanhabrinquedo.webapi
{
    public class Startup
    {
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly SymmetricSecurityKey _signingKey;

        public IHostingEnvironment Environment { get; set; }

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            Environment = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            _secretKey = Configuration["TokenAuthentication:SecretKey"];
            _audience = Configuration["TokenAuthentication:Audience"];
            _issuer = Configuration["TokenAuthentication:Issuer"];
            _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_secretKey));
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureOrm(services);

            RegisterService(services);

            ConfigureAuthentication(services);

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, CampanhaBrinquedoContext dbContext)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseAuthentication();

            app.UseJWTTokenProviderMiddleware(Options.Create(new TokenProviderOptions
            {
                Audience = _audience,
                Issuer = _issuer,
                SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256)
            }));
            app.UseMvc();

            DbInitializer.Initialize(dbContext);
        }

        private void ConfigureAuthentication(IServiceCollection services)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey)),

                        ValidateIssuer = true,
                        ValidIssuer = _issuer,

                        ValidateAudience = true,
                        ValidAudience = _audience,

                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });
        }

        private void ConfigureOrm(IServiceCollection services)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CampanhaBrinquedoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                );
        }

        private static void RegisterService(IServiceCollection services)
        {
            ContainerBootStrapper.RegisterServices(services);
        }
    }
}

