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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext _context;

        public IndexModel(RazorPagesAriulesanne.Data.RazorPagesAriulesanneContext context)
        {
            _context = context;
        }

        public IList<Ettevotja> Ettevotja { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ettevotja != null)
            {
                Ettevotja = await _context.Ettevotja.ToListAsync();
            }
        }
    }
}
