using System;

public class FaltaModel
{
    public int IdFalta { get; set; }
    public AlunoModel MatriculaAluno { get; set; }
    public DisciplinaModel IDDisciplina { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataLancamento { get; set; }
}
