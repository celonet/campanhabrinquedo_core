using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.domain.Repositorios
{
    public interface IPadrinhoRepositorio : Insert<Padrinho>, Search<Padrinho>, Update<Padrinho>, Delete<Padrinho> { }
}