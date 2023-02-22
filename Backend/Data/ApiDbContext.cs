using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Backend.Models;

namespace Backend.Data
{
    public class ApiDbContext : DbContext {

        public DbSet<LivroModel> Livros { get; set; }
        
        public DbSet<AutorModel> Autores { get; set; }

        
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<LivroModel>()
            .HasIndex(c => c.Titulo)
            .IsUnique();

            base.OnModelCreating(builder);
            
        }
    }

}