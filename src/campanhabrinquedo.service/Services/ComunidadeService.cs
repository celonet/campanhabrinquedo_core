namespace campanhabrinquedo.service.Services
{
    using campanhabrinquedo.domain.Services;
    using campanhabrinquedo.domain.Repositories;
    using campanhabrinquedo.domain.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class ComunidadeService : IComunidadeService
    {
        private IComunidadeRepository _repository;

        public ComunidadeService(IComunidadeRepository repository)
        {
            _repository = repository;
        }

        public List<Comunidade> ListaComunidades()
        {
            return _repository.List().ToList();
        }
    }
}