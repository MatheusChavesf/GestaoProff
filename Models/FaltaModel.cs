using System;
namespace GestaoProff.Models
{
    public class FaltaModel
    {
        public int IdFalta { get; set; }
        public AlunoModel? MatriculaAluno { get; set; }
        public DisciplinaModel? IdDisciplina { get; set; }
        public int QuantidadeFalta { get; set; }
        public DateTime DataFalta { get; set; }
    }
}