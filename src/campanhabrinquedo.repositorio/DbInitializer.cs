using Microsoft.EntityFrameworkCore;
using campanhabrinquedo.domain.Entidades;
using System;
using System.Linq;

namespace campanhabrinquedo.repositorio
{
    public static class DbInitializer
    {
        public static void Initialize(CampanhaBrinquedoContext context)
        {
            context.Database.EnsureCreated();

            if(context.Usuario.Any()){
                var usuario = new Usuario {
                    UsuarioId = Guid.NewGuid(),
                    Nome= "Marcelo Lopes da Silva",
                    Email= "marcelo.lopesdasilva@gmail.com",
                    Senha= "123456",
                    DataCadastro= DateTime.Now
                };

                context.Usuario.Add(usuario);

                context.SaveChanges();
            }
        }
    }
}