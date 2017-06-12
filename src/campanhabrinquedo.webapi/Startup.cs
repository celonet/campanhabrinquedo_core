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
using campanhabrinquedo.domain.Repositorio;
using campanhabrinquedo.repositorio.Repositorio;

namespace campanhabrinquedo.webapi
{
    public class Startup
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

            services
                .AddTransient<IUsuarioRepositorio, UsuarioRepositorio>()
                .AddTransient<IComunidadeRepositorio, ComunidadeRepositorio>()
                .AddTransient<ICriancaRepositorio, CriancaRepositorio>()
                .AddTransient<IPadrinhoRepositorio, PadrinhoRepositorio>()
                .AddTransient<IResponsavelRepositorio, ResponsavelRepositorio>()
                ;
            
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, CampanhaBrinquedoContext context)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            DbInitializer.Initialize(context);
        }
    }
}
