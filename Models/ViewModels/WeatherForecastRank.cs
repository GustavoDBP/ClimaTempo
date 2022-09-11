using System.Collections.Generic;

namespace ClimaTempo.Models.ViewModels
{
    public class WeatherForecastRank
    {
        public List<WeatherForecast> Top3Hottest{ get; set; }
        public List<WeatherForecast> Top3Coldest{ get; set; }
    }
}
