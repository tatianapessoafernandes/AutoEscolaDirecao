using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaDirecao.Pages.Alunos
{
    public class Alunos
    {
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        public int Documento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public int Telefone { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]

        public string Curso { get; set; }

    }
}
