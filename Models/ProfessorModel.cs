using System;
using System.ComponentModel.DataAnnotations;

public class ProfessorModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome do Professor � obrigat�rio.")]
    public string NomeProfessor { get; set; }

    [Required(ErrorMessage = "O campo Disciplina � obrigat�rio.")]
    public string Disciplina { get; set; }
}
