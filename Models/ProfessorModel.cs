using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoProff.Models
{

    public class ProfessorModel
    {
        public int IdProfessor { get; set; }

        [Required(ErrorMessage = "O campo Nome do Professor é obrigatório.")]
        public string? NomeProfessor { get; set; }

        public DisciplinaModel? IdDisciplina { get; set; }
    }
}