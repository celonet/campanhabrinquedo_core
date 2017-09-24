using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.domain.Repositorios
{
    public interface ICriancaRepositorio : Insert<Crianca>, Search<Crianca>, Update<Crianca>, Delete<Crianca> { }
}