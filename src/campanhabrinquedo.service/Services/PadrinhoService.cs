using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class PadrinhoService : IPadrinhoService
    {
        private IPadrinhoRepository _repository;

        public PadrinhoService(IPadrinhoRepository repository)
        {
            _repository = repository;
        }
    }
}