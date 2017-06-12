using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Repositorio
{
    public interface IComunidadeRepositorio
    {
        void RegistraComunidade(Comunidade comunidade);
        void DeletaComunidade(Guid id);
        void AlteraComunidade(Comunidade comunidade);
        IList<Comunidade> ListaComunidades();
        Comunidade BuscaComunidade(Guid id);
        Comunidade BuscaComunidade(string nome);
    }
}