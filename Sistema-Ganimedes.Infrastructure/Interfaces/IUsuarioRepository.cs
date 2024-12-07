using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ganimedes.Application.AtualizarPerfilRequest;

namespace Sistema_Ganimedes.Infrastructure.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetUserByEmail(string email);
        void UpdatePerfil(Usuario usuario);
    }
}
