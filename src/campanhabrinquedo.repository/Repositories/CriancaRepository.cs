using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class CriancaRepository : Repository<Crianca>, ICriancaRepository
    {
        public CriancaRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}