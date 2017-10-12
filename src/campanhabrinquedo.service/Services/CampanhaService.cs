using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
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