using System;
using System.ComponentModel.DataAnnotations;

public class DisciplinaModel
{
    public int IdDisciplina { get; set; }

    [Required(ErrorMessage = "O campo Nome da Disciplina � obrigat�rio.")]
    public string NomeDisciplina { get; set; }

    public string Descricao { get; set; }
    public CursoModel IdCurso { get; set; }

    public FaltaModel IdFalta { get; set; }
}
