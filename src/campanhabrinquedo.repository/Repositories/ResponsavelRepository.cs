using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class ResponsavelRepository : Repository<Responsavel>, IResponsavelRepository
    {
        public ResponsavelRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}