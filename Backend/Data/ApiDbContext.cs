using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Backend.Models;
using Microsoft.AspNetCore;

namespace Backend.Data
{
    public class ApiDbContext : DbContext {

        public DbSet<Livro> Livros { get; set; }
        
        public DbSet<Autor> Autores { get; set; }

        
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }
    }

}