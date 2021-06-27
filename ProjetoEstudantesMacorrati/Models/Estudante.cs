using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UniversidadeMacoratti.Models;

namespace ProjetoEstudantesMacorrati.Models
{
    public class Estudante
    {
        public int EstudanteID { get; set; }
        public string SobreNome { get; set; }
        public string Nome { get; set; }
        public DateTime DataMatricula { get; set; }
        // A listagem de matriculas que o estudante possui.
        public ICollection<Matricula> Matriculas { get; set; }

        [NotMapped]
        public IEnumerable<Estudante> ListagemEstudante { get; set; }

        [NotMapped]
        public int TotalEstudantes { get; set; }
    }
}