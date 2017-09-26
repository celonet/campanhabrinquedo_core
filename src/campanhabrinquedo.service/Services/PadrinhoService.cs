namespace campanhabrinquedo.service.Services
{
    using campanhabrinquedo.domain.Services;
    using campanhabrinquedo.domain.Repositories;

    public class PadrinhoService : IPadrinhoService
    {
        private IPadrinhoRepository _repository;

        public PadrinhoService(IPadrinhoRepository repository)
        {
            _repository = repository;
        }
    }
}