using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAriulesanne.Data;
using RazorPagesAriulesanne.Models;

namespace RazorPagesAriulesanne.Pages.Osavotjad_Ettevotja
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DeleteModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Ettevotja Ettevotja { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ettevotja == null)
            {
                return NotFound();
            }

            var ettevotja = await _context.Ettevotja.FirstOrDefaultAsync(m => m.EttevotjaID == id);

            if (ettevotja == null)
            {
                return NotFound();
            }
            else 
            {
                Ettevotja = ettevotja;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ettevotja == null)
            {
                return NotFound();
            }
            var ettevotja = await _context.Ettevotja.FindAsync(id);

            if (ettevotja != null)
            {
                Ettevotja = ettevotja;
                _context.Ettevotja.Remove(Ettevotja);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
