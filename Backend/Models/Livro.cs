using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Livro {

        [Key]
        public int IdLivro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(100)]
        public String Titulo { get; set; }

        [StringLength(100)]
        public String Subtitulo { get; set; }

        [StringLength(500)]
        public String Resumo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        [Range(0, 10000)]
        public int QuantPaginas { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(150)]
        public String Editora { get; set; }

        [Range(2, 20)]
        public int Edicao { get; set; }  

        public List<Autor> Autores { get; set; }

    }
    
}