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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DetailsModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

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
    }
}
