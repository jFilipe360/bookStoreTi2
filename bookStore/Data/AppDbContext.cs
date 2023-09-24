using bookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Escritor> Escritores { get; set; }
        public DbSet<Editora> Editoras { get; set; }

    }
}
