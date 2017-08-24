using System;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class CriancaRepositorio : ICriancaRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public CriancaRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void Insert<Crianca>.Insert(Crianca entidade)
        {
            _context.Crianca.Add(entidade);
            _context.SaveChanges();
        }
    }
}