using System;
using campanhabrinquedo.Application.Services;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Interfaces;
using NSubstitute;
using Xunit;

namespace campanhabrinquedo.tests.Application.Services
{
    public abstract class ServiceActionsUnitTests<T> where T : EntityBase
    {
        protected ServiceAction<T> Service;
        protected IRepository<T> Repository;
        protected T Entity;
        protected T EntityInvalid;

        [Fact]
        public void Deve_Chamar_Metodo_Listar()
        {
            Service.Lista();
            Repository.Received().List();
        }

        [Fact]
        public void Deve_Chamar_Metodo_RetornaPorId_Passando_Id()
        {
            var id = Guid.NewGuid();
            Service.RetornaPorId(id);
            Repository.Received().FindById(id);
        }

        [Fact]
        public void Deve_Chamar_Metodo_Insere_Passando_Objeto()
        {
            Service.Insere(Entity);
            Repository.Received().Create(Entity);
        }

        [Fact]
        public void Nao_Deve_Chamar_Metodo_Insere_Quando_Passado_Objeto_Invalido()
        {
            Service.Insere(EntityInvalid);
            Repository.DidNotReceive().Create(Entity);
        }

        [Fact]
        public void Deve_Chamar_Metodo_Alterar_Passando_Objeto()
        {
           Service.Altera(Entity);
            Repository.Received().Update(Entity);
        }

        [Fact]
        public void Nao_Deve_Chamar_Metodo_Alterar_Quando_Passado_Objeto_Invalido()
        {
            Service.Altera(EntityInvalid);
            Repository.DidNotReceive().Update(EntityInvalid);
        }

        [Fact]
        public void Deve_Chamar_Metodo_Deleta_Passando_Id()
        {
            var id = Guid.NewGuid();
            Service.Deleta(id);
            Repository.Received().Delete(id);
        }
    }
}
