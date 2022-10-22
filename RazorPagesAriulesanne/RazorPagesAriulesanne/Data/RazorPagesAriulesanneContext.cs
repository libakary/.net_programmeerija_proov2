using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesAriulesanne.Models;

namespace RazorPagesAriulesanne.Data
{
    public class RazorPagesAriulesanneContext : DbContext
    {
        public RazorPagesAriulesanneContext (DbContextOptions<RazorPagesAriulesanneContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesAriulesanne.Models.Eraisik> Eraisik { get; set; } = default!;

        public DbSet<RazorPagesAriulesanne.Models.Ettevotja> Ettevotja { get; set; }

        public DbSet<RazorPagesAriulesanne.Models.Uritus> Uritus { get; set; }
    }
}
