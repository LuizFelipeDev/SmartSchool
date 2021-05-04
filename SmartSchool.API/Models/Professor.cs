using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Professor
    {
        public Professor()
        {

        }

        public Professor(int Id, int Registro, string Nome, string Sobrenome)
        {
            this.Id = Id;
            this.Registro = Registro;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }

        public int Id { get; set; }

        public int Registro { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;

        public bool Ativo { get; set; } = true;
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}
