using Microsoft.AspNetCore.Mvc;
using Sistema_Ganimedes.Application.Interfaces;
using Sistema_Ganimedes.Application.AtualizarPerfilRequest;

namespace Sistema_Ganimedes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("atualizarPerfil")]
        public IActionResult AtualizarPerfil([FromBody] PerfilAtualizacaoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var usuarioAtualizado = _usuarioService.AtualizarPerfil(request);
                return Ok(new { mensagem = "Perfil atualizado com sucesso.", usuario = usuarioAtualizado });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensagem = "Erro ao atualizar o perfil.", erro = ex.Message });
            }
        }
    }
}
