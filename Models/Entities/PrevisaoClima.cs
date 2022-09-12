using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimaTempo.Models.Entities
{
    public enum EClima
    {
        Ensolarado,
        Nublado,
        Chuvoso,
        Tempestuoso
    }

    public class PrevisaoClima
    {
        [Key]
        public int Id { get; set; }
        public EClima Clima { get; set; }
        [Column(TypeName ="decimal(6, 2)")]
        public decimal TemperaturaMinima { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal TemperaturaMaxima { get; set; }
        public DateTime DataPrevisao{ get; set; }
        public int CidadeId { get; set; }

        public virtual Cidade Cidade{ get; set; }
    }
}
