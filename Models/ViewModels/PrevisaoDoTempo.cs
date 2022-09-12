using System;

namespace ClimaTempo.Models.ViewModels
{
    public class PrevisaoDoTempo
    {
        public string Cidade { get; set; }
        public string UF { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public string Clima { get; set; }
        public DateTime DataPrevisao { get; set; }
    }
}
