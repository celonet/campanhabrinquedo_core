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

        void Insert<Responsavel>.Insert(Responsavel entidade)
        {
            throw new NotImplementedException();
        }
    }
}