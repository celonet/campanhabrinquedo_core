namespace campanhabrinquedo.service.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using campanhabrinquedo.domain.Entidades;
    using campanhabrinquedo.domain.Services;
    using campanhabrinquedo.domain.Repositorios;

    public class ComunidadeService : IComunidadeService
    {
        private IComunidadeRepositorio _repository;
        public ComunidadeService(IComunidadeRepositorio repository)
        {
            _repository = repository;
        }
        List<Comunidade> IComunidadeService.ListaComunidades()
        {
            return _repository.List().ToList();
        }
    }
}