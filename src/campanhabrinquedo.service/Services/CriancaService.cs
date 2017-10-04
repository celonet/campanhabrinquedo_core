using campanhabrinquedo.domain.Services;
using campanhabrinquedo.domain.Repositories;

namespace campanhabrinquedo.service.Services
{
    public class CriancaService : ICriancaService
    {
        private ICriancaRepository _repository;

        public CriancaService(ICriancaRepository repositorio)
        {
            _repository = repositorio;
        }
    }
}