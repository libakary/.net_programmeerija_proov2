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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public DetailsModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

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
    }
}
