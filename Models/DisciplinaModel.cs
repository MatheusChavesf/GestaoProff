using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoProff.Models
{
    public class DisciplinaModel
    {
        public int IdDisciplina { get; set; }

        [Required(ErrorMessage = "O campo Nome da Disciplina � obrigat�rio.")]
        public string? NomeDisciplina { get; set; }
        public CursoModel? IdCurso { get; set; }

    }

}
