using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UniversidadeMacoratti.Models;

namespace ProjetoEstudantesMacorrati.Models
{
    public class Curso
    {
        //DatabaseGeneratedOption.Identity) deixa auto increment sempre que a inclusão de registro na tabela de curso.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
