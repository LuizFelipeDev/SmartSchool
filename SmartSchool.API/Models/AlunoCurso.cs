using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class AlunoCurso
    {
        public AlunoCurso()
        {

        }

        public AlunoCurso(int AlunoId, int cursoId)
        {
            this.AlunoId = AlunoId;
            this.CursoId = cursoId;
        }

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; }

        public int? Nota { get; set; } = null;

        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
