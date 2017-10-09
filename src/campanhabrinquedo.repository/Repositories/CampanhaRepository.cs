using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class CampanhaRepository : Repository<Campanha>, ICampanhaRepository
    {
        public CampanhaRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}