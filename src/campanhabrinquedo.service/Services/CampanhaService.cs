using campanhabrinquedo.domain.Services;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.service.Services
{
    public class CampanhaService : ICampanhaService
    {
        private ICampanhaRepository _repositorio;

        public CampanhaService(ICampanhaRepository repositorio)
        {
            _repositorio = repositorio;
        }
    }
}