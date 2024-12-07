using Sistema_Ganimedes.Application.AtualizarPerfilRequest;
using Sistema_Ganimedes.Infrastructure.Common.Persistence;
using Sistema_Ganimedes.Infrastructure.Interfaces;

namespace Sistema_Ganimedes.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbContext _dbContext;

        public UsuarioRepository(DbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public Usuario GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerfil(Usuario usuario)
        {
           throw new NotImplementedException();
        }
    }

}
