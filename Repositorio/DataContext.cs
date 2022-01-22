using Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositorio
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(b => b.Id)
                .IsRequired();
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
