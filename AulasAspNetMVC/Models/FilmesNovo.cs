using System.ComponentModel.DataAnnotations;

namespace AulasAspNetMVC.Models
{
    public class FilmesNovo
    {
        public int Id { get; set; }
        [Display(Name ="Título")]
        public string Titulo { get; set; } = string.Empty;
        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Genero")]
        public string Genero { get; set; } = string.Empty;
        public decimal Valor { get; set; }
    }
}
