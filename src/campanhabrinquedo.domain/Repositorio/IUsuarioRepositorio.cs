using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Repositorio
{
    public interface IUsuarioRepositorio
    {
        void RegistraUsuario(Usuario Usuario);
        void DeletaUsuario(Guid id);
        void AlteraUsuario(Usuario Usuario);
        IList<Usuario> ListaUsuarios();
        Usuario BuscaUsuario(Guid id);
        Usuario BuscaUsuario(string nome);
    }
}