using System;
using System.Collections.Generic;

namespace ProjetoFullStack1.Models
{
    public partial class Aluno
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; } = null!;
        public DateTime DataNasc { get; set; }
        public string NomeResponsavel1 { get; set; } = null!;
        public string? NomeResponsavel2 { get; set; }
        public int TelContato { get; set; }
        public int CodTurma { get; set; }
        public DateTime DataInicio { get; set; }
        public int Frequencia { get; set; }

        public virtual Turma CodTurmaNavigation { get; set; } = null!;
    }
}
