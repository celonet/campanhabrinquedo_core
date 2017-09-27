using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface IPadrinhoRepository : ICreate<Padrinho>, IUpdate<Padrinho>, IDelete<Padrinho>, ISearch<Padrinho> { }
}