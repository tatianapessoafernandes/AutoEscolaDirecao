using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoEscolaDirecao.Data;

namespace AutoEscolaDirecao.Pages.Alunos
{
    public class CreateModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public CreateModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Alunos Alunos { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Alunos.Add(Alunos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
