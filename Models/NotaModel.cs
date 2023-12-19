using System;

public class NotaModel
{
    public int IdNota { get; set; }
    public AlunoModel MatriculaAluno { get; set; }
    public DisciplinaModel IDDisciplina { get; set; }
    public string DescricaoNota { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataLancamento { get; set; }
}
