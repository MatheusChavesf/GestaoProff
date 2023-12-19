using System;
using System.ComponentModel.DataAnnotations;

public class ProfessorModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome do Professor é obrigatório.")]
    public string NomeProfessor { get; set; }

    [Required(ErrorMessage = "O campo Disciplina é obrigatório.")]
    public string Disciplina { get; set; }
}
