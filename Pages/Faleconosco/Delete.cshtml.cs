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
    public class DeleteModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public DeleteModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Faleconosco Faleconosco { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Faleconosco = await _context.Faleconosco.FirstOrDefaultAsync(m => m.ID == id);

            if (Faleconosco == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Faleconosco = await _context.Faleconosco.FindAsync(id);

            if (Faleconosco != null)
            {
                _context.Faleconosco.Remove(Faleconosco);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
