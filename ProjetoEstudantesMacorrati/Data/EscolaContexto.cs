using Microsoft.EntityFrameworkCore;
using ProjetoEstudantesMacorrati.Models;
using UniversidadeMacoratti.Models;


namespace ProjetoEstudantesMacorrati.Data
{
    /*um conjunto de entidades 
    corresponde a uma tabela de banco de dados e uma entidade corresponde a uma linha na tabela.*/
    public class EscolaContexto : DbContext
    {
        public EscolaContexto(DbContextOptions<EscolaContexto> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
        }
    }
}
