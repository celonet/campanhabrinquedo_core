using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CampanhaBrinquedoContext _context;

        public UsuarioRepository(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        public void Create(Usuario entitie)
        {
            _context.Usuario.Add(entitie);
            _context.SaveChanges();
        }

        public void Update(Usuario entidade)
        {
            _context.Usuario.Update(entidade);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var usuario = _context.Usuario.Find(id);
            if (usuario == null) return;
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario FindByExpression(Func<Usuario, bool> expression)
        {
            return _context.Usuario.FirstOrDefault(expression);
        }

        public Usuario FindById(Guid id)
        {
            return _context.Usuario.Find(id);
        }

        public IEnumerable<Usuario> List()
        {
            return _context.Usuario.ToList();
        }

        public IEnumerable<Usuario> List(Func<Usuario, bool> expression)
        {
            return _context.Usuario.Where(expression);
        }
    }
}