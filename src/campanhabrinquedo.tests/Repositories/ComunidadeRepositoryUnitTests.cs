using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.repository.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;
using campanhabrinquedo.repository;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace campanhabrinquedo.tests.Repositories
{    
    public class ComunidadeRepositoryUnitTests
    {
        private DbContextOptions _contextOptions;

        private ComunidadeRepository _repository;

        public ComunidadeRepositoryUnitTests()
        {
            _contextOptions = new DbContextOptionsBuilder<CampanhaBrinquedoContext>()
                .UseInMemoryDatabase("Add_writes_to_database")
                .Options;
        }

        ~ComunidadeRepositoryUnitTests()
        {
            _contextOptions = null;
            _repository.Dispose();
        }

        [Fact]
        public void Create()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.List().Should().HaveCount(1);
            }
        }

        [Fact]
        public void Update()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);

                const string nomeAlterado = "Comunidade Alterada";
                this._repository.Create(new Comunidade("Comunidade Update I", "Bairro Update I"));
                var comunidade = this._repository.List().First();

                var comunidadeAlterada = new Comunidade(comunidade.Id, nomeAlterado, comunidade.Bairro);
                this._repository.Update(comunidadeAlterada);

                var comunidadeResultado = this._repository.List().First();

                comunidadeResultado.Nome.Should().Be(nomeAlterado);
                this._repository.List().Should().HaveCount(1);
            }
        }

        [Fact]
        public void Delete()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.Create(new Comunidade("Comunidade II", "Bairro II"));

                var comunidade = this._repository.List().First();
                this._repository.List().Should().HaveCount(3);
                this._repository.Delete(comunidade.Id);
                this._repository.List().Should().HaveCount(2);
            }
        }

        [Fact]
        public void List()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.Create(new Comunidade("Comunidade II", "Bairro II"));

                this._repository.List().Should().HaveCount(13);
            }
        }

        [Fact]
        public void List_Com_Parametros()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.Create(new Comunidade("Comunidade II", "Bairro II"));

                this._repository.List(c => c.Nome.Contains("II")).Should().HaveCount(6);
            }
        }

        [Fact]
        public void FindById()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.Create(new Comunidade("Comunidade II", "Bairro II"));
                this._repository.Create(new Comunidade("Comunidade III", "Bairro III"));

                var lastComunidade = this._repository.List().Last();
                this._repository.FindById(lastComunidade.Id).Nome.Should().Be(lastComunidade.Nome);
                this._repository.FindById(lastComunidade.Id).Bairro.Should().Be(lastComunidade.Bairro);
            }
        }

        [Fact]
        public void FindByExpressionAsync()
        {
            using (var context = new CampanhaBrinquedoContext(_contextOptions))
            {
                _repository = new ComunidadeRepository(context);
                this._repository.Create(new Comunidade("Comunidade I", "Bairro I"));
                this._repository.Create(new Comunidade("Comunidade II", "Bairro II"));
                this._repository.Create(new Comunidade("Comunidade III", "Bairro III"));

                var comunidade = this._repository.FindByExpression(c => c.Nome.Contains("III"));
                comunidade.Nome.Should().Be("Comunidade III");
                comunidade.Bairro.Should().Be("Bairro III");
            }
        }
    }
}
