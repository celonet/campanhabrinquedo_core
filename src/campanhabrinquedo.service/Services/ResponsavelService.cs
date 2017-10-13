using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Interfaces;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class ResponsavelService : ServiceAction<Responsavel>, IResponsavelService
    {
        public ResponsavelService(IRepository<Responsavel> repository)
            : base(repository) { }

        public override bool Existe(Responsavel entity)
        {
            return Repository.FindByExpression(_ =>
                    _.Nome == entity.Nome &&
                    _.RG == entity.RG
                ) != null;  
        }
    }
}