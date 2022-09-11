using System;

namespace ClimaTempo.Models.ViewModels
{
    public class WeatherForecast
    {
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Clima { get; set; }
        public DateTime DataPrevisao { get; set; }
    }
}
