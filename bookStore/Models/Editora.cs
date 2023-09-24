using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace bookStore.Models
{
    public class Editora
    {
        [Key]
        public int EditoraId { get; set; }

        [Display(Name = "Logotipo")]
        [Required(ErrorMessage = "O URL do logo da editora é necessário")]
        public string URLLogo { get; set; }

        [Display(Name = "Editora")]
        [Required(ErrorMessage = "O nome da editora é necessário")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "O nome completo tem de ter entre 3 a 30 caracteres")]
        public string NomeEditora { get; set; }

        [Display(Name = "Ano de Fundação")]
        [Required(ErrorMessage = "O ano de fundação é necessário")]
        public int AnoFundacao { get; set; }

        [Display(Name = "Slogan")]
        [Required(ErrorMessage = "O slogan é necessário")]
        public string Slogan { get; set; }

        [Display(Name = "Website")]
        [Required(ErrorMessage = "O URL do website é necessário")]
        public string Website { get; set; }     


        //Relacionamentos
        public List<Livro> Livros { get; set; }
    }
}
