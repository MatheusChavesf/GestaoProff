using GestaoProff.Models;

namespace GestaoProff.Models
{
    public class CursoModel
    {
        public int IdCurso { get; set; }
        public string? NomeCurso { get; set; }
        public PeriodoLetivoModel? IdPeriodoLetivo { get; set; }
    }
}

