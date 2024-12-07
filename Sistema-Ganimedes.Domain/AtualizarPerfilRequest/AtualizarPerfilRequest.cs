namespace Sistema_Ganimedes.Application.AtualizarPerfilRequest
{
    public class PerfilAtualizacaoRequest
    {
        public required string Perfil { get; set; }
        public required string LinkLattes { get; set; }
        public required string Email { get; set; }
        public string? DtLattes { get; set; }
        public int? AnoIngresso { get; set; }
        public string? Curso { get; set; }
        public string? ExameProficiencia { get; set; }
        public string? ExameQualificacao { get; set; }
        public string? Orientador { get; set; }
        public string? PrazoTese { get; set; }
        public string? PrazoQualificacao { get; set; }
    }
}