using System;
using System.Collections.Generic;

namespace ProjetoFullStack1.Models
{
    public partial class Turma
    {
        public Turma()
        {
            Alunos = new HashSet<Aluno>();
        }

        public int CodTurma { get; set; }
        public string ProfResponsavel { get; set; } = null!;
        public string Instrumento { get; set; } = null!;
        public string Turno { get; set; } = null!;

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
