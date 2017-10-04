namespace campanhabrinquedo.service.Services
{
    using domain.Services;
    using domain.Repositories;

    public class PadrinhoService : IPadrinhoService
    {
        private IPadrinhoRepository _repository;

        public PadrinhoService(IPadrinhoRepository repository)
        {
            _repository = repository;
        }
    }
}