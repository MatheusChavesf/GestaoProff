using System;
using System.ComponentModel.DataAnnotations;

public class AlunoModel
{
    public int MatriculaAluno { get; set; }

    [Required(ErrorMessage = "O campo Nome do Aluno é obrigatório.")]
    public string NomeAluno { get; set; }

    public string Curso { get; set; }
    public string Disciplina { get; set; }
    public object Faltas { get; internal set; }
}
