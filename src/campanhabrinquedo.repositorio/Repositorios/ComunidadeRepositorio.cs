using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Repositorios;
using campanhabrinquedo.domain.Repositorios.Base;

namespace campanhabrinquedo.repositorio.Repositorios
{
    public class ComunidadeRepositorio : IComunidadeRepositorio
    {
        private CampanhaBrinquedoContext _context;

        public ComunidadeRepositorio(CampanhaBrinquedoContext context)
        {
            _context = context;
        }

        void Insert<Comunidade>.Insert(Comunidade entidade)
        {
            _context.Comunidade.Add(entidade);
            _context.SaveChanges();
        }
    }
}