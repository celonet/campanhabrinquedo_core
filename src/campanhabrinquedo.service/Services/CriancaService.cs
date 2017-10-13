using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
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