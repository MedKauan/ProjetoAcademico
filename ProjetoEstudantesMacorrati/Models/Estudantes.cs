using System;
using System.Collections.Generic;
using UniversidadeMacoratti.Models;

namespace ProjetoEstudantesMacorrati.Models
{
    public class Estudantes
    {
        public int EstudanteID { get; set; }
        public string SobreNome { get; set; }
        public string Nome { get; set; }
        public DateTime DataMatricula { get; set; }
        // A listagem de matriculas que o estudante possui.
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
