using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulasAspNetMVC.Models
{
    public class FilmesNovo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Esse campo é obrigatorio")]
        [Display(Name ="Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        [StringLength(10)]//Quantidade de caracteres
        [Display(Name = "Genero")]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]        
        public decimal Valor { get; set; }

        [Range(0,10, ErrorMessage ="Digite Numeros de 0 a 10 ")]
        public int? Pontos { get; set; }
    }
}
