using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public ResponsavelRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void Insert<Responsavel>.Insert(Responsavel entidade)
        {
            _context.Responsavel.Add(entidade);
            _context.SaveChanges();
        }
    }
}