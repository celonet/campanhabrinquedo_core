using AutoMapper;
using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Interfaces;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace campanhabrinquedo.ioc
{
    public class ContainerBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services
                //Application
                .AddSingleton(Mapper.Configuration)
                .AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService))
                //repositorios
                .AddSingleton<IUsuarioRepository, UsuarioRepository>()
                .AddSingleton<IComunidadeRepository, ComunidadeRepository>()
                .AddSingleton<ICriancaRepository, CriancaRepository>()
                .AddSingleton<IPadrinhoRepository, PadrinhoRepository>()
                .AddSingleton<IResponsavelRepository, ResponsavelRepository>()
                .AddSingleton(typeof(IRepository<>), typeof(Repository<>))
                //services
                .AddScoped<IUsuarioService, UsuarioService>()
                .AddScoped<IComunidadeService, ComunidadeService>()
                .AddScoped<ICriancaService, CriancaService>()
                .AddScoped<ICampanhaService, CampanhaService>()
                .AddScoped<IPadrinhoService, PadrinhoService>()
                .AddScoped<IResponsavelService, ResponsavelService>();
        }
    }
}
