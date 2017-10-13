using System;
using System.Collections.Generic;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class PadrinhoRepository : Repository<Padrinho>, IPadrinhoRepository
    {
        public PadrinhoRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}