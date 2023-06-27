using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AulaAspNetFilmes.Data;
using AulaAspNetFilmes.Modelo;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AulaAspNetFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly AulaAspNetFilmes.Data.AulaAspNetFilmesContext _context;

        public IndexModel(AulaAspNetFilmes.Data.AulaAspNetFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string  TermoBusca { get; set; }

        [BindProperty(SupportsGet = true)]
        public string  FilmeGenero { get; set; }

        public SelectList  Genero { get; set; }

        public async Task OnGetAsync()
        {
            var filmes = from m in _context.Filme select m; 

            if (!string.IsNullOrWhiteSpace(TermoBusca))
            {
                filmes = filmes.Where(f => f.Titulo.Contains(TermoBusca));
            }
            Filme = await _context.Filme.ToListAsync();

        }
    }
}
