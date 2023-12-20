using System;
namespace GestaoProff.Models
{
    public class NotaModel
    {
        public int IdNota { get; set; }
        public AlunoModel? MatriculaAluno { get; set; }
        public DisciplinaModel? IdDisciplina { get; set; }
        public decimal ValorNota { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}