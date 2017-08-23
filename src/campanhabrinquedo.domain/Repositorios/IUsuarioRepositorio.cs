using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.domain.Repositorios
{
    public interface IUsuarioRepositorio : Insert<Usuario>, Update<Usuario>, Delete<Usuario>, Search<Usuario> { }
}