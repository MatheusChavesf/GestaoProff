using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoProff.Models
{

    public class ProfessorModel
    {
        public int IdProfessor { get; set; }

        [Required(ErrorMessage = "O campo Nome do Professor � obrigat�rio.")]
        public string? NomeProfessor { get; set; }

        public DisciplinaModel? IdDisciplina { get; set; }
    }
}