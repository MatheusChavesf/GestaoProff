using GestaoProff.Models;
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
        public DbSet<AvaliacaoModel> Avaliacoes { get; set; }
        public DbSet<CertificadoModel> Certificados { get; set; }
        public DbSet<PeriodoLetivoModel> PeriodosLetivos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABHNTBL6800317\\DBGESTAOPROFF;Database=GESTAOPROFF;Integrated Security=True;");
        }


    }
}
