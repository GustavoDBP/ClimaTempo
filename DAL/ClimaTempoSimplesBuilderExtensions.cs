using ClimaTempo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClimaTempo.DAL
{
    public static class ClimaTempoSimplesBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>().HasData(
                 new Estado() { Id = 1, Nome = "Rio de Jaineiro", UF = "RJ" },
                 new Estado() { Id = 2, Nome = "São Paulo", UF = "SP" }
             );

            modelBuilder.Entity<Cidade>().HasData(
                new Cidade() { Id = 1, Nome = "São Paulo", EstadoId = 2 },
                new Cidade() { Id = 2, Nome = "Campinas", EstadoId = 2 },
                new Cidade() { Id = 3, Nome = "Rio de Janeiro", EstadoId = 1 },
                new Cidade() { Id = 4, Nome = "Barra Mansa", EstadoId = 1 },
                new Cidade() { Id = 5, Nome = "Volta Redonda", EstadoId = 1 }
            );

            modelBuilder.Entity<PrevisaoClima>().HasData(
                new PrevisaoClima() { Id = 1, Clima = EClima.Ensolarado, TemperaturaMaxima = 34, TemperaturaMinima = 24, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(0) },
                new PrevisaoClima() { Id = 2, Clima = EClima.Ensolarado, TemperaturaMaxima = 30, TemperaturaMinima = 20, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(1) },
                new PrevisaoClima() { Id = 3, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 16, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(2) },
                new PrevisaoClima() { Id = 4, Clima = EClima.Nublado, TemperaturaMaxima = 25, TemperaturaMinima = 14, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(3) },
                new PrevisaoClima() { Id = 5, Clima = EClima.Chuvoso, TemperaturaMaxima = 24, TemperaturaMinima = 14, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(4) },
                new PrevisaoClima() { Id = 6, Clima = EClima.Tempestuoso, TemperaturaMaxima = 25, TemperaturaMinima = 15, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(5) },
                new PrevisaoClima() { Id = 7, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 20, CidadeId = 1, DataPrevisao = DateTime.Now.AddDays(6) },

                new PrevisaoClima() { Id = 8, Clima = EClima.Chuvoso, TemperaturaMaxima = 32, TemperaturaMinima = 22, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(0) },
                new PrevisaoClima() { Id = 9, Clima = EClima.Ensolarado, TemperaturaMaxima = 33, TemperaturaMinima = 20, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(1) },
                new PrevisaoClima() { Id = 10, Clima = EClima.Tempestuoso, TemperaturaMaxima = 26, TemperaturaMinima = 16, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(2) },
                new PrevisaoClima() { Id = 11, Clima = EClima.Nublado, TemperaturaMaxima = 25, TemperaturaMinima = 14, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(3) },
                new PrevisaoClima() { Id = 12, Clima = EClima.Chuvoso, TemperaturaMaxima = 23, TemperaturaMinima = 14, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(4) },
                new PrevisaoClima() { Id = 13, Clima = EClima.Tempestuoso, TemperaturaMaxima = 25, TemperaturaMinima = 15, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(5) },
                new PrevisaoClima() { Id = 14, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 20, CidadeId = 2, DataPrevisao = DateTime.Now.AddDays(6) },

                new PrevisaoClima() { Id = 15, Clima = EClima.Ensolarado, TemperaturaMaxima = 30, TemperaturaMinima = 20, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(0) },
                new PrevisaoClima() { Id = 16, Clima = EClima.Ensolarado, TemperaturaMaxima = 30, TemperaturaMinima = 20, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(1) },
                new PrevisaoClima() { Id = 17, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 16, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(2) },
                new PrevisaoClima() { Id = 18, Clima = EClima.Nublado, TemperaturaMaxima = 25, TemperaturaMinima = 14, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(3) },
                new PrevisaoClima() { Id = 19, Clima = EClima.Chuvoso, TemperaturaMaxima = 24, TemperaturaMinima = 14, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(4) },
                new PrevisaoClima() { Id = 20, Clima = EClima.Tempestuoso, TemperaturaMaxima = 25, TemperaturaMinima = 15, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(5) },
                new PrevisaoClima() { Id = 21, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 20, CidadeId = 3, DataPrevisao = DateTime.Now.AddDays(6) },

                new PrevisaoClima() { Id = 22, Clima = EClima.Ensolarado, TemperaturaMaxima = 28, TemperaturaMinima = 18, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(0) },
                new PrevisaoClima() { Id = 23, Clima = EClima.Ensolarado, TemperaturaMaxima = 30, TemperaturaMinima = 20, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(1) },
                new PrevisaoClima() { Id = 24, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 16, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(2) },
                new PrevisaoClima() { Id = 25, Clima = EClima.Nublado, TemperaturaMaxima = 25, TemperaturaMinima = 14, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(3) },
                new PrevisaoClima() { Id = 26, Clima = EClima.Chuvoso, TemperaturaMaxima = 24, TemperaturaMinima = 14, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(4) },
                new PrevisaoClima() { Id = 27, Clima = EClima.Tempestuoso, TemperaturaMaxima = 25, TemperaturaMinima = 15, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(5) },
                new PrevisaoClima() { Id = 28, Clima = EClima.Nublado, TemperaturaMaxima = 26, TemperaturaMinima = 20, CidadeId = 4, DataPrevisao = DateTime.Now.AddDays(6) },

                new PrevisaoClima() { Id = 29, Clima = EClima.Tempestuoso, TemperaturaMaxima = 26, TemperaturaMinima = 16, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(0) },
                new PrevisaoClima() { Id = 30, Clima = EClima.Nublado, TemperaturaMaxima = 30, TemperaturaMinima = 22, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(1) },
                new PrevisaoClima() { Id = 31, Clima = EClima.Nublado, TemperaturaMaxima = 27, TemperaturaMinima = 18, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(2) },
                new PrevisaoClima() { Id = 32, Clima = EClima.Nublado, TemperaturaMaxima = 22, TemperaturaMinima = 14, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(3) },
                new PrevisaoClima() { Id = 33, Clima = EClima.Ensolarado, TemperaturaMaxima = 21, TemperaturaMinima = 13, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(4) },
                new PrevisaoClima() { Id = 34, Clima = EClima.Tempestuoso, TemperaturaMaxima = 22, TemperaturaMinima = 14, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(5) },
                new PrevisaoClima() { Id = 35, Clima = EClima.Nublado, TemperaturaMaxima = 24, TemperaturaMinima = 19, CidadeId = 5, DataPrevisao = DateTime.Now.AddDays(6) }
            );
        }
    }
}
