using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulasAspNetMVC.Models;

namespace AulasAspNetMVC.Data
{
    public class AulasAspNetMVCContext : DbContext
    {
        public AulasAspNetMVCContext (DbContextOptions<AulasAspNetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AulasAspNetMVC.Models.FilmesNovo> FilmesNovo { get; set; } = default!;
    }
}
