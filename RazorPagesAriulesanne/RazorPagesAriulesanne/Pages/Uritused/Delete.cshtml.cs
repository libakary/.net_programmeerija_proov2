using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAriulesanne.Data;
using RazorPagesAriulesanne.Models;

namespace RazorPagesAriulesanne.Pages.Uritused
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DeleteModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Uritus Uritus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Uritus == null)
            {
                return NotFound();
            }

            var uritus = await _context.Uritus.FirstOrDefaultAsync(m => m.UritusID == id);

            if (uritus == null)
            {
                return NotFound();
            }
            else 
            {
                Uritus = uritus;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Uritus == null)
            {
                return NotFound();
            }
            var uritus = await _context.Uritus.FindAsync(id);

            if (uritus != null)
            {
                Uritus = uritus;
                _context.Uritus.Remove(Uritus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
