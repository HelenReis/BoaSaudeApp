using Dominio;
using Dominio.AtendimentoModel;
using Dominio.Usuario;
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
            modelBuilder.Entity<Atendimento>()
                .Property(b => b.Id)
                .IsRequired();

            modelBuilder.Entity<Atendimento>()
                .Property(b => b.Id)
                .IsRequired();

            modelBuilder.Entity<Associado>()
                .Property(b => b.Id)
                .IsRequired();

            modelBuilder.Entity<Atendimento>()
                .HasOne(a => a.Associado)
                .WithMany(u => u.Atendimentos);

            modelBuilder.Entity<Atendimento>()
                .HasOne(a => a.Prestador)
                .WithMany(u => u.Atendimentos);

            modelBuilder.Entity<Atendimento>()
                .HasOne(a => a.Conveniado)
                .WithMany(u => u.Atendimentos);

            modelBuilder.Entity<ConveniadoPrestador>()
                .HasKey(x => new { x.ConveniadoId, x.PrestadorId });
        }

        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Associado> Associado { get; set; }
        public DbSet<Prestador> Prestador { get; set; }
        public DbSet<Prestador> Conveniado { get; set; }
        public DbSet<ConveniadoPrestador> ConveniadoPrestador { get; set; }
    }
}
