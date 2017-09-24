using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.domain.Repositorios
{
    public interface IResponsavelRepositorio : Insert<Responsavel>, Search<Responsavel>, Update<Responsavel>, Delete<Responsavel> { }
}