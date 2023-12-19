using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GestaoProff.DBConfig
{
    public class AppDbContext : DbContext
    {
        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<CursoModel> Cursos { get; set; }
        public DbSet<DisciplinaModel> Disciplinas { get; set; }
        public DbSet<FaltaModel> Faltas { get; set; }
        public DbSet<NotaModel> Notas { get; set; }
        public DbSet<ProfessorModel> Professores { get; set; }

        // Configura��es adicionais do DbContext, se necess�rio...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Substitua "sua_string_de_conexao" pela sua string de conex�o SQL Server
            optionsBuilder.UseSqlServer("sua_string_de_conexao");
        }

    }
}
