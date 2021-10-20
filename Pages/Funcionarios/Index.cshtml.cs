using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaDirecao.Data;

namespace AutoEscolaDirecao.Pages.Funcionarios
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public IndexModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        public IList<Funcionarios> Funcionarios { get;set; }

        public async Task OnGetAsync()
        {
            Funcionarios = await _context.Funcionarios.ToListAsync();
        }
    }
}
