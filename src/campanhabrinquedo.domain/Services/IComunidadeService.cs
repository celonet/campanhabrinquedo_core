using System;
using System.Linq;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IComunidadeService
    {
        IQueryable<Comunidade> ListaComunidades();
        Comunidade RetornaComunidadePorId(Guid id);
        void InsereComunidade(Comunidade comunidade);
        void AlteraComunidade(Comunidade comunidade);
        void DeletaComunidade(Guid id);
    }
}