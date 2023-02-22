using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Backend.Models;

namespace Backend.Models
{
    public class AutorModel
    {
        
        [Key]
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        public string NomeAutor { get; set; }

        [ForeignKey("LivroId")]
        public int LivroID { get; set; }

        public virtual LivroModel? Livro { get; set; }   
    }
}