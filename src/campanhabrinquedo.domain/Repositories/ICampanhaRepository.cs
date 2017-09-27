using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Actions;

namespace campanhabrinquedo.domain.Repositories
{
    public interface ICampanhaRepository : ICreate<Campanha>, IUpdate<Campanha>, IDelete<Campanha>, ISearch<Campanha> { }
}