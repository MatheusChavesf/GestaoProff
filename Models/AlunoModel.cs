using System;
using System.ComponentModel.DataAnnotations;
namespace GestaoProff.Models
{
    public class AlunoModel
    {
        public int MatriculaAluno { get; set; }

        [Required(ErrorMessage = "O campo Nome do Aluno é obrigatório.")]
        public string? NomeAluno { get; set; }

        public CursoModel? IdCurso { get; set; }
        public string? EmailAluno { get; set; }
        public string? TelefoneAluno { get; set; }
    }

}
