using Sistema_Ganimedes.Application.Interfaces;
using Sistema_Ganimedes.Application.AtualizarPerfilRequest;
using Sistema_Ganimedes.Infrastructure.Interfaces;

namespace Sistema_Ganimedes.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioData AtualizarPerfil(PerfilAtualizacaoRequest request)
        {
            var usuario = _usuarioRepository.GetUserByEmail(request.Email);
            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuario.AtualizarPerfil(request);

            _usuarioRepository.UpdatePerfil(usuario);

            return new UsuarioData(usuario);
        }
    }

}
