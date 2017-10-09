namespace campanhabrinquedo.service.Services
{
    using domain.Services;
    using domain.Repositories;
    using domain.Entities;
    using domain.Validators;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class ComunidadeService : IComunidadeService
    {
        private readonly IComunidadeRepository _repository;
        private readonly ComunidadeValidator _validator;

        public ComunidadeService(IComunidadeRepository repository)
        {
            _repository = repository;
            _validator = new ComunidadeValidator();
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
            var result = _validator.Validate(comunidade);
            if (!result.IsValid) return false;
            if (ExisteComunidade(comunidade)) return false;
            _repository.Create(comunidade);
            return true;
        }

        private bool ExisteComunidade(Comunidade comunidade)
        {
            return _repository.FindByExpression(_ => _.Nome == comunidade.Nome && _.Bairro == comunidade.Bairro) != null;
        }

        public bool AlteraComunidade(Comunidade comunidade)
        {
            var result = _validator.Validate(comunidade);
            if (!result.IsValid) return false;

            var c = new Comunidade(comunidade.Id, comunidade.Nome, comunidade.Bairro);
            c.IncluiDataCadastro();
            _repository.Update(c);
            return true;
        }

        public void DeletaComunidade(Guid id)
        {
            _repository.Delete(id);
        }
    }
}