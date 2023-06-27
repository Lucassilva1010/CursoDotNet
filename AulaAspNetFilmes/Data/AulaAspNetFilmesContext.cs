using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulaAspNetFilmes.Modelo;

namespace AulaAspNetFilmes.Data
{
    public class AulaAspNetFilmesContext : DbContext
    {
        public AulaAspNetFilmesContext (DbContextOptions<AulaAspNetFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<AulaAspNetFilmes.Modelo.Filme> Filme { get; set; } = default!;
    }
}
