using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Aluno
    {
        public Aluno() {}

        public Aluno(int Id, int Matricula, string Nome, string Sobrenome, string Telefone, DateTime DataNasc)
        {
            this.Id = Id;
            this.Matricula = Matricula;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Telefone = Telefone;
            this.DataNasc = DataNasc;
        }

        public int Id { get; set; }

        public int Matricula { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public int Idade { get; set; }

        public DateTime DataNasc { get; set; }

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;

        public bool Ativo { get; set; } = true;

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}
