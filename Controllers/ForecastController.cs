using ClimaTempo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ClimaTempo.Controllers
{
    [Route("forecast")]
    public class ForecastController : Controller
    {
        [HttpGet("rank")]
        public IActionResult Rank()
        {
            var rank = new WeatherForecastRank()
            {
                Top3Hottest = new List<WeatherForecast>() {
                    new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19 },
                    new WeatherForecast() { Cidade = "São Paulo", UF = "SP", Min = 6, Max = 19 }
                },
                Top3Coldest = new List<WeatherForecast>() {
                    new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19 },
                    new WeatherForecast() { Cidade = "São Paulo", UF = "SP", Min = 6, Max = 19 }
                },
            };

            return Json(rank);
        }

        [HttpGet("overview")]
        public IActionResult Overview()
        {
            var overview = new List<WeatherForecast>()
            {
                new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="ensolarado" },
                new WeatherForecast() { Cidade = "São Paulo", UF = "SP", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="chuvoso"  },
                new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="tempestuoso"  },
                new WeatherForecast() { Cidade = "São Paulo", UF = "SP", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="nublado"  },
                new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="ensolarado"  },
                new WeatherForecast() { Cidade = "São Paulo", UF = "SP", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="ensolarado"  },
                new WeatherForecast() { Cidade = "Petrópolis", UF = "RJ", Min = 6, Max = 19, DataPrevisao= DateTime.Now, Clima="ensolarado"  }
            };

            return Json(overview);
        }

        [HttpGet("cities")]
        public IActionResult Cities()
        {
            var cities = new List<City>()
            {
                new City(){Nome="Petrópolis", Id=0},
                new City(){Nome="São Paulo", Id=1}
            };

            return Json(cities);
        }
    }
}
