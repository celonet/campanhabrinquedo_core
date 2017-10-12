using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositories;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.domain.Validators;

namespace campanhabrinquedo.Application.Services
{
    public class ComunidadeService : IComunidadeService
    {
        private readonly IComunidadeRepository _repository;
        private readonly ComunidadeValidator _validator;

        public ComunidadeService(IComunidadeRepository repository)
        {
            _repository = repository;
            _validator = new ComunidadeValidator();
        }

        public IQueryable<Comunidade> ListaComunidades()
        {
            return _repository.List();
        }

        public Comunidade RetornaComunidadePorId(Guid id)
        {
            return _repository.FindById(id);
        }

        public void InsereComunidade(Comunidade comunidade)
        {
            var result = _validator.Validate(comunidade);
            if (!result.IsValid) return;
            if (ExisteComunidade(comunidade)) return;
            _repository.Create(comunidade);
        }

        private bool ExisteComunidade(Comunidade comunidade)
        {
            return _repository.FindByExpression(_ => _.Nome == comunidade.Nome && _.Bairro == comunidade.Bairro) != null;
        }

        public void AlteraComunidade(Comunidade comunidade)
        {
            var result = _validator.Validate(comunidade);
            if (!result.IsValid) return;

            comunidade.IncluiDataCadastro();
            _repository.Update(comunidade);
        }

        public void DeletaComunidade(Guid id)
        {
            _repository.Delete(id);
        }
    }
}