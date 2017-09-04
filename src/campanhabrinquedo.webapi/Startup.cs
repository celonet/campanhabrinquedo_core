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
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CampanhaBrinquedoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = "";
                    options.Audience = Configuration.GetSection("TokenAuthentication:Audience").Value;
                    options.RequireHttpsMetadata = false;
                });

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

            //ConfigureAuth(app);

            app.UseMvc();

            DbInitializer.Initialize(context);
        }
    }
}

