using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class ComunidadeRepository : Repository<Comunidade>, IComunidadeRepository
    {
        public ComunidadeRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}