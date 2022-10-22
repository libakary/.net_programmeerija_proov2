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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DetailsModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

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
    }
}
