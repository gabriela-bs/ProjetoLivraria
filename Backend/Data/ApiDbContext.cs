using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Backend.Models;
using Microsoft.AspNetCore;

namespace Backend.Data
{
    public class ApiDbContext : DbContext {

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public ApiDbContext (DbContextOptions<ApiDbContext> options) : base (options) { }


        protected override void OnModelCreating(ModelBuilder builder){

        builder.Entity<Autor>()
            .HasOne<Livro>(t => t.Livro)
            .WithMany(t => t.Autores)
            .HasForeignKey(t => t.FKAutor);


            base.OnModelCreating(builder);
        }
    }

}