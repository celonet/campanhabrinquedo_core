﻿using System;
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
using campanhabrinquedo.repositorio;
using campanhabrinquedo.service.Services;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.repositorio.Repositorios;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.webapi.Middleware;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;

namespace campanhabrinquedo.webapi
{
    public partial class Startup
    {
        private string _secretKey;
        private string _issuer;
        private string _audience;
        private SymmetricSecurityKey _signingKey;

        public IHostingEnvironment Environment { get; set; }

        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            Environment = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
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
                .AddCookie(options => options.SlidingExpiration = true)
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
            services
                //repositorios
                .AddTransient<IUsuarioRepositorio, UsuarioRepositorio>()
                .AddTransient<IComunidadeRepositorio, ComunidadeRepositorio>()
                .AddTransient<ICriancaRepositorio, CriancaRepositorio>()
                .AddTransient<IPadrinhoRepositorio, PadrinhoRepositorio>()
                .AddTransient<IResponsavelRepositorio, ResponsavelRepositorio>()
                //services
                .AddTransient<IUsuarioService, UsuarioService>()
                .AddTransient<IComunidadeService, ComunidadeService>()
                .AddTransient<ICriancaService, CriancaService>()
                .AddTransient<ICampanhaService, CampanhaService>()
                .AddTransient<IPadrinhoService, PadrinhoService>()
                .AddTransient<IResponsavelService, ResponsavelService>();
        }
    }
}

