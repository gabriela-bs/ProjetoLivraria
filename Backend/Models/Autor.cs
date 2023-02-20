using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Backend.Models
{
    public class Autor {
        
        [Key]
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(50)]
        public String NomeAutor { get; set; }

        public int FKAutor { get; set; }

        public Livro Livro { get; set;}

    }
}