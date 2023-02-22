using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Backend.Models;
using Microsoft.AspNetCore;

namespace Backend.Data
{
    public class ApiDbContext : DbContext {

        public DbSet<LivroModel> Livros { get; set; }
        
        public DbSet<AutorModel> Autores { get; set; }

        
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }
    }

}