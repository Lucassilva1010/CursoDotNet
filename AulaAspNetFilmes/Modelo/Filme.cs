using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulaAspNetFilmes.Modelo
{
    public class Filme
    {

        public int ID { get; set; }

        [MaxLength(50,ErrorMessage ="Limite atingido")]
        [Display(Name ="Título")]
        public string Titulo { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }


        [Display(Name ="Gênero")]
        [StringLength(30, MinimumLength = 3)]
         [Required(ErrorMessage ="Digite o gênero do filme")]
        public string Genero { get; set; } = string.Empty;
        
        
        [Display(Name ="Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        [Required(ErrorMessage = "A avaliação é de 0 a 5")]
        public int Pontos { get; set; } = 0;
    }
}
