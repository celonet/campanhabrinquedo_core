using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositorio;
using campanhabrinquedo.repositorio;

namespace campanhabrinquedo.repositorio.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public UsuarioRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void IUsuarioRepositorio.AlteraUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
        }

        Usuario IUsuarioRepositorio.BuscaUsuario(Guid id)
        {
            return _context.Usuario.FirstOrDefault(usuario => usuario.UsuarioId == id);
        }

        Usuario IUsuarioRepositorio.BuscaUsuario(string nome)
        {
            return _context.Usuario.FirstOrDefault(_ => _.Nome == nome);
        }

        void IUsuarioRepositorio.DeletaUsuario(Guid id)
        {
            var usuario = _context.Usuario.FirstOrDefault(_context => _context.UsuarioId == id);
            _context.Usuario.Remove(usuario);
        }

        IList<Usuario> IUsuarioRepositorio.ListaUsuarios()
        {
            return _context.Usuario.ToList();
        }

        void IUsuarioRepositorio.RegistraUsuario(Usuario usuario)
        {
            _context.Usuario.Add(new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha
            });
            _context.SaveChanges();
        }
    }
}