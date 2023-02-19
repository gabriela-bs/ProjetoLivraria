using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Backend.Models;

namespace Backend.Data
{
    public class ApiDbContext : DbContext {

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }
    }

}