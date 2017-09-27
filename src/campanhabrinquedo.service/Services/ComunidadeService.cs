namespace campanhabrinquedo.service.Services
{
    using campanhabrinquedo.domain.Services;
    using campanhabrinquedo.domain.Repositories;
    using campanhabrinquedo.domain.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System;

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

        public Comunidade RetornaComunidadePorId(Guid id)
        {
            return _repository.FindById(id);
        }
    }
}