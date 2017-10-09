using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.repository.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CampanhaBrinquedoContext context)
            : base(context) { }
    }
}