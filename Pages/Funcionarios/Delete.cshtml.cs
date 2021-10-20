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
    public class DeleteModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public DeleteModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Funcionarios Funcionarios { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionarios = await _context.Funcionarios.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcionarios == null)
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

            Funcionarios = await _context.Funcionarios.FindAsync(id);

            if (Funcionarios != null)
            {
                _context.Funcionarios.Remove(Funcionarios);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
