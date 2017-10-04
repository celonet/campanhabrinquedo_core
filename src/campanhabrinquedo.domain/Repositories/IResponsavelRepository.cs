using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface IResponsavelRepository : ICreate<Responsavel>, IUpdate<Responsavel>, IDelete, ISearch<Responsavel> { }
}