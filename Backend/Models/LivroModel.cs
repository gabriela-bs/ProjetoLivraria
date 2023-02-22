using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Backend.Models;

namespace Backend.Models
{
    public class LivroModel
    {

        [Key]
        public int IdLivro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [StringLength(100)]
        public string? Subtitulo { get; set; }

        [StringLength(500)]
        public string? Resumo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(0, 10000)]
        public int QuantPaginas { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(150)]
        public string Editora { get; set; }

        [Range(2, 20)]
        public int? Edicao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(0, 10000)]
        public int QuantLivros { get; set; }

        
        [JsonIgnore]
        public ICollection<AutorModel>? Autores { get; set; }

    }
}