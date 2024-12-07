using Sistema_Ganimedes.Application.AtualizarPerfilRequest;

namespace Sistema_Ganimedes.Application.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioDTO AtualizarPerfil(PerfilAtualizacaoRequest request);
    }
}