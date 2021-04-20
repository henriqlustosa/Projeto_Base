
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Models;

namespace Projeto_MVC.Dados
{
    public class AppDbContext : DbContext
    {
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Microrganismo> Microrganismos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SistemaIsolamentoDB;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exame>()
                .HasOne(l => l.Microrganismo)
                .WithMany(c => c.Exames)
                .HasForeignKey(l => l.IdMicrorganismo);

        }
    }
}
 