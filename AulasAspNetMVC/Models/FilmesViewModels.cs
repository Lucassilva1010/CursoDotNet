using Microsoft.AspNetCore.Mvc.Rendering;

namespace AulasAspNetMVC.Models
{
    public class FilmesViewModels
    {
        public List<FilmesNovo>? Filmes { get; set; }

        public SelectList? Genero { get; set; }
        public string? Texto { get; set; }
    }
}
