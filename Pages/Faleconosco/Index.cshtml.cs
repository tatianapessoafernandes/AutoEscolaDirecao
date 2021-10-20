using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaDirecao.Data;

namespace AutoEscolaDirecao.Pages.Faleconosco
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public IndexModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        public IList<Faleconosco> Faleconosco { get;set; }

        public async Task OnGetAsync()
        {
            Faleconosco = await _context.Faleconosco.ToListAsync();
        }
    }
}
