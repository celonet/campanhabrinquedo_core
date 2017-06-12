using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositorio;

namespace campanhabrinquedo.repositorio.Repositorio
{
    public class ComunidadeRepositorio : IComunidadeRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public ComunidadeRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void IComunidadeRepositorio.AlteraComunidade(Comunidade comunidade)
        {
            
        }

        Comunidade IComunidadeRepositorio.BuscaComunidade(Guid id)
        {
            throw new NotImplementedException();
        }

        Comunidade IComunidadeRepositorio.BuscaComunidade(string nome)
        {
            throw new NotImplementedException();
        }

        void IComunidadeRepositorio.DeletaComunidade(Guid id)
        {
            throw new NotImplementedException();
        }

        IList<Comunidade> IComunidadeRepositorio.ListaComunidades()
        {
            throw new NotImplementedException();
        }

        void IComunidadeRepositorio.RegistraComunidade(Comunidade comunidade)
        {
            throw new NotImplementedException();
        }
    }
}