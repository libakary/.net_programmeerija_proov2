using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAriulesanne.Data;
using RazorPagesAriulesanne.Models;

namespace RazorPagesAriulesanne.Pages.Osavotjad
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DeleteModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Eraisik Eraisik { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Eraisik == null)
            {
                return NotFound();
            }

            var eraisik = await _context.Eraisik.FirstOrDefaultAsync(m => m.EraisikID == id);

            if (eraisik == null)
            {
                return NotFound();
            }
            else 
            {
                Eraisik = eraisik;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Eraisik == null)
            {
                return NotFound();
            }
            var eraisik = await _context.Eraisik.FindAsync(id);

            if (eraisik != null)
            {
                Eraisik = eraisik;
                _context.Eraisik.Remove(Eraisik);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
