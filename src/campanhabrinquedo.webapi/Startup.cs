using System;
using System.IO;
using System.Text;
using AutoMapper;
using campanhabrinquedo.Application.AutoMapper;
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
using campanhabrinquedo.repository;
using campanhabrinquedo.ioc;
using Swashbuckle.AspNetCore.Swagger;

namespace campanhabrinquedo.webapi
{
    public class Startup
    {
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            _secretKey = Configuration["JwtIssuerOptions:SecretKey"];
            _audience = Configuration["JwtIssuerOptions:Audience"];
            _issuer = Configuration["JwtIssuerOptions:Issuer"];
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureOrm(services);

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddSwaggerGen(_ =>
            {
                _.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Api da Campanha do Brinquedo",
                        Version = "v1",
                        Description = "Api para acesso a Campanha do Brinquedo",
                        Contact = new Contact
                        {
                            Name = "Marcelo Lopes da Silva Aguiar",
                            Email = "marcelo.lopesdasilva@gmail.com",
                            Url = "https://github.com/celonet"
                        }
                    }
                );
            });

            services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

            ConfigureAuthentication(services);

            RegisterService(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            if (env.IsDevelopment())
            {
                loggerFactory.AddDebug();
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseAuthentication();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Campanha do Brinquedo");
            });
            app.UseMvc();          
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

