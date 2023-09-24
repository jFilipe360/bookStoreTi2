using bookStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookStore.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "O título do livro é necessário")]
        public string Titulo { get; set; }

        [Display(Name = "Sinópse")]
        [Required(ErrorMessage = "A sinopse é necessária")]
        public string Sinopse { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço do livro é necessário")]
        public double Preco { get; set; }

        [Display(Name = "Capa")]
        [Required(ErrorMessage = "O URL da foto de capa é necessário")]
        public string URlImagem { get; set; }

        [Display(Name = "Ano")]
        [Required(ErrorMessage = "O ano é necessário")]
        public int DataLancamento { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A categoria é necessária")]
        public LivroCategoria LivroCategora { get; set; }

        //Relacionamentos
        //Editora
        [ForeignKey("Editora")]
        public int EditoraId { get; set; }
        
        public Editora Editora { get; set; }

        //Escritor
        [ForeignKey("Escritor")]
        public int EscritorId { get; set; }
        public Escritor Escritor { get; set;}
    }
}
