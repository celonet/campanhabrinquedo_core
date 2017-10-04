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

        public bool InsereComunidade(Comunidade comunidade)
        {
            if (!ExisteComunidade(comunidade))
            {
                _repository.Create(comunidade);
                return true;
            }
            return false;
        }

        private bool ExisteComunidade(Comunidade comunidade)
        {
            return _repository.FindByExpression(_ => _.Nome == comunidade.Nome && _.Bairro == comunidade.Bairro) != null;
        }

        public void AlteraComunidade(Comunidade comunidade)
        {
            _repository.Update(comunidade);
        }

        public void DeletaComunidade(Guid id)
        {
            _repository.Delete(id);
        }
    }
}