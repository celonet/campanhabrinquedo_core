using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using campanhabrinquedo.repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication;
using System.Text;
using CustomTokenAuthProvider;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.Extensions.Options;
using campanhabrinquedo.service.Services;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.repositorio.Repositorios;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace campanhabrinquedo.webapi
{
    public partial class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CampanhaBrinquedoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            RegisterService(services);

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
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
                .AddTransient<IUsuarioService, UsuarioService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, CampanhaBrinquedoContext context)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            ConfigureAuth(app);

            app.UseMvc();

            DbInitializer.Initialize(context);
        }
    }
}

