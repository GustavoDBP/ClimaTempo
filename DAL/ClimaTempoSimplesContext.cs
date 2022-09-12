using ClimaTempo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClimaTempo.DAL
{
    public class ClimaTempoSimplesContext : DbContext
    {
        public ClimaTempoSimplesContext(DbContextOptions<ClimaTempoSimplesContext> options) : base(options)
        {
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<PrevisaoClima> PrevisoesClima { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClimaTempoSimples");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}