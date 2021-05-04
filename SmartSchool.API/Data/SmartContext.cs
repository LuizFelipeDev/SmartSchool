using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options)
        {
            //mysql -h localhost -u root -p
        }


        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public DbSet<AlunoCurso> AlunosCursos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>().HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<AlunoCurso>()
                .HasKey(AD => new { AD.AlunoId, AD.CursoId });                       
        }
    }
}
