using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.repository.Configurations
{
    public static class DbInitializer
    {
        public static void Initialize(CampanhaBrinquedoContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Usuario.Any())
            {
                var usuario = new Usuario("Marcelo Lopes da Silva", "marcelo.lopesdasilva@gmail.com", "123456");
                usuario.IncluiDataCadastro();
                context.Usuario.Add(usuario);
            }

            if (!context.Comunidade.Any())
            {
                var comunidades = new List<Comunidade> {
                    new Comunidade("Nossa Senhora Aparecida","Finco"),
                    new Comunidade("Nossa Senhora das Graças","Vila Pelé, Pq. Rio Grande"),
                    new Comunidade("Nossa Senhora Fatima","Tupã"),
                    new Comunidade("Sta. Terezinha","Estoril"),
                    new Comunidade("Santo Antonio","Boa Vista"),
                    new Comunidade("São João Batista","Riacho Grande"),
                    new Comunidade("São Jose","Jussara"),
                    new Comunidade("São Francisco de Assis","Capelinha"),
                    new Comunidade("Sem Comunidade","")
                };
                context.Comunidade.AddRange(comunidades.ToArray());
            };

            context.SaveChanges();
        }
    }
}