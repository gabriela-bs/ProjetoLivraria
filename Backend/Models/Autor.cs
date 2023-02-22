using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Backend.Models
{
    public class Autor {
        
        [Key]
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string NomeAutor { get; set; }

        [ForeignKey("LivroID")]
        public int LivroID { get; set; }

        public virtual Livro? Livro { get; set; }

    }
}