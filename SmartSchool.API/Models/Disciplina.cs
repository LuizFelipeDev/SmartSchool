using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }

        public Disciplina(int Id, string Nome, int ProfessorId, int cursoId)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.ProfessorId = ProfessorId;
            this.CursoId = cursoId;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public int CargaHorario { get; set; }

        public int? PrerequisitoId { get; set; } = null;

        public Disciplina Prerequisito { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}
