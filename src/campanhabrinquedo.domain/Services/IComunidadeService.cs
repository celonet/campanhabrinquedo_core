using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;

namespace campanhabrinquedo.domain.Services
{
    public interface IComunidadeService
    {
        List<Comunidade> ListaComunidades();
        Comunidade RetornaComunidadePorId(Guid id);
        bool InsereComunidade(Comunidade comunidade);
        bool AlteraComunidade(Comunidade comunidade);
        void DeletaComunidade(Guid id);
    }
}