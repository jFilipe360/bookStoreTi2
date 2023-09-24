using System.ComponentModel.DataAnnotations;

namespace bookStore.Models
{
    public class Escritor
    {
        [Key]
        public int EscritorId { get; set; }

        [Display(Name = "Fotografia")]
        [Required(ErrorMessage = "O URL da foto é necessário")]
        public string URLFoto { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome completo é necessário")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome completo tem de ter entre 4 a 50 caracteres")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "A biografia é necessária")]
        public string Biografia { get; set; }

        //Relacionamentos
        public List<Livro> Livros { get; set; }
    }
}
