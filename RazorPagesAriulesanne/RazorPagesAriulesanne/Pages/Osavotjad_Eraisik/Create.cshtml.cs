using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesAriulesanne.Data;
using RazorPagesAriulesanne.Models;

namespace RazorPagesAriulesanne.Pages.Osavotjad
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public CreateModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Eraisik Eraisik { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Eraisik.Add(Eraisik);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
