using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscolaDirecao.Pages.Alunos;
using AutoEscolaDirecao.Pages.Funcionarios;
using AutoEscolaDirecao.Pages.Treinamentos;
using AutoEscolaDirecao.Pages.Faleconosco;

namespace AutoEscolaDirecao.Data
{
    public class AutoEscolaDirecaoContext : DbContext
    {
        public AutoEscolaDirecaoContext (DbContextOptions<AutoEscolaDirecaoContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP-UF6V4115\SQLEXPRESS; Initial Catalog=BDAutoEscolaDirecao; Integrated Security = true");
        }

        public DbSet<AutoEscolaDirecao.Pages.Alunos.Alunos> Alunos { get; set; }

        public DbSet<AutoEscolaDirecao.Pages.Funcionarios.Funcionarios> Funcionarios { get; set; }

        public DbSet<AutoEscolaDirecao.Pages.Treinamentos.Treinamentos> Treinamentos { get; set; }

        public DbSet<AutoEscolaDirecao.Pages.Faleconosco.Faleconosco> Faleconosco { get; set; }
    }
}
