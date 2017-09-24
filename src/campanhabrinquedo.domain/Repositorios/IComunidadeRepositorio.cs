using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.domain.Repositorios
{
    public interface IComunidadeRepositorio : Insert<Comunidade>, Search<Comunidade>, Update<Comunidade>, Delete<Comunidade> { }
}