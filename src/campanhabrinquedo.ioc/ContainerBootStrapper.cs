using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.repository.Repositories;
using campanhabrinquedo.service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace campanhabrinquedo.ioc
{
    public class ContainerBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services
               //repositorios
               .AddTransient<IUsuarioRepository, UsuarioRepository>()
               .AddTransient<IComunidadeRepository, ComunidadeRepository>()
               .AddTransient<ICriancaRepository, CriancaRepository>()
               .AddTransient<IPadrinhoRepository, PadrinhoRepository>()
               .AddTransient<IResponsavelRepository, ResponsavelRepository>()
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
