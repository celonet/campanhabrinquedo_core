using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class PadrinhoRepositorio : IPadrinhoRepositorio
    {
        private CampanhaBrinquedoContext _context;

        void Insert<Padrinho>.Insert(Padrinho entidade)
        {
            throw new NotImplementedException();
        }
    }
}