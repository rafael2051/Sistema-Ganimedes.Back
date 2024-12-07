using Sistema_Ganimedes.Application.AtualizarPerfilRequest;

namespace Sistema_Ganimedes.Application.AtualizarPerfilRequest
{
    public class Usuario
    {
        public string Perfil { get; private set; }
        public string Email { get; private set; }
        public string LinkLattes { get; private set; }
        public DateTime? DtLattes { get; private set; }
        public int? AnoIngresso { get; private set; }
        public string Curso { get; private set; }
        public string ExameProficiencia { get; private set; }
        public string ExameQualificacao { get; private set; }
        public string Orientador { get; private set; }
        public DateTime? PrazoTese { get; private set; }
        public DateTime? PrazoQualificacao { get; private set; }

        public Usuario(
        string perfil, string email, string linkLattes, DateTime dtLattes,
        int anoIngresso, string curso, string exameProficiencia,
        string exameQualificacao, string orientador, DateTime prazoTese, DateTime prazoQualificacao)
        {
            Perfil = perfil;
            Email = email;
            LinkLattes = linkLattes;
            DtLattes = dtLattes;
            AnoIngresso = anoIngresso;
            Curso = curso;
            ExameProficiencia = exameProficiencia;
            ExameQualificacao = exameQualificacao;
            Orientador = orientador;
            PrazoTese = prazoTese;
            PrazoQualificacao = prazoQualificacao;
        }

        public void AtualizarPerfil(PerfilAtualizacaoRequest request)
        {
            Perfil = request.Perfil;
            LinkLattes = request.LinkLattes;
            DtLattes = !string.IsNullOrEmpty(request.DtLattes) ? DateTime.Parse(request.DtLattes) : null;
            AnoIngresso = request.AnoIngresso;
            Curso = request.Curso ?? string.Empty;
            ExameProficiencia = request.ExameProficiencia ?? string.Empty;
            ExameQualificacao = request.ExameQualificacao ?? string.Empty;
            Orientador = request.Orientador ?? string.Empty;
            PrazoTese = !string.IsNullOrEmpty(request.PrazoTese) ? DateTime.Parse(request.PrazoTese) : null;
            PrazoQualificacao = !string.IsNullOrEmpty(request.PrazoQualificacao) ? DateTime.Parse(request.PrazoQualificacao) : null;
        }
    }

}