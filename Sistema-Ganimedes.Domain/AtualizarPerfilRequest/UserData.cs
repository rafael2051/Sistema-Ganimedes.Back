namespace Sistema_Ganimedes.Application.AtualizarPerfilRequest
{
    public class UsuarioData
    {
        public string Perfil { get; set; }
        public string Email { get; set; }
        public string LinkLattes { get; set; }

        public UsuarioData(Usuario usuario)
        {
            Perfil = usuario.Perfil;
            Email = usuario.Email;
            LinkLattes = usuario.LinkLattes;
        }
    }
}