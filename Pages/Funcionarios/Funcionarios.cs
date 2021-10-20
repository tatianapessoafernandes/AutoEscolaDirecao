using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaDirecao.Pages.Funcionarios
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Cargo { get; set; }

        public DateTime DataAdmissao { get; set; }
    }
}
