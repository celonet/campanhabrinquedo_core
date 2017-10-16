using System.Threading.Tasks;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Interfaces;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.Application.Services
{
    public class UsuarioService : ServiceAction<Usuario>, IUsuarioService
    {
        public UsuarioService(IRepository<Usuario> repository)
            : base(repository) { }

        public override bool Existe(Usuario entity)
        {
            return Repository.FindByExpression(_ => _.Nome == entity.Nome && _.Email == entity.Email) != null;
        }

        public async Task<bool> LogarUsuario(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) && string.IsNullOrWhiteSpace(senha))
                return false;

            var usuarioExiste = await Repository.FindByExpressionAsync(usuario => usuario.Email == login && usuario.Senha == senha);
            return usuarioExiste != null;
        }
    }
}