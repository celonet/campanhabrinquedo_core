using System;
using System.Linq;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public UsuarioRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void domain.Actions.Delete<Usuario>.Delete(Guid entidadeId)
        {
            var usuario = _context.Usuario.FirstOrDefault(_ => _.UsuarioId == entidadeId);
            if(usuario != null) {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
        }

        Usuario domain.Actions.Search<Usuario>.FindByExpression(Func<Usuario, bool> expression)
        {
            return _context.Usuario.FirstOrDefault(expression);
        }

        Usuario domain.Actions.Search<Usuario>.FindById(Guid entidadeId)
        {
            return _context.Usuario.FirstOrDefault(_ => _.UsuarioId == entidadeId);
        }

        void domain.Actions.Insert<Usuario>.Insert(Usuario entidade)
        {
            _context.Usuario.Add(entidade);
            _context.SaveChanges();
        }

        IEnumerable<Usuario> domain.Actions.Search<Usuario>.List()
        {
            return _context.Usuario.ToList();
        }

        IEnumerable<Usuario> domain.Actions.Search<Usuario>.List(Func<Usuario, bool> expression)
        {
            return _context.Usuario.Where(expression);
        }

        void domain.Actions.Update<Usuario>.Update(Usuario entidade)
        {
            _context.Usuario.Update(entidade);
        }
    }
}