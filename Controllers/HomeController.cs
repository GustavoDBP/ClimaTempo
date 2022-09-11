using ClimaTempo.Models;
using ClimaTempo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Top3Hottest"] = new List<WeatherForecast>() {
                new WeatherForecast() {
                    Cidade = "Petrópolis/RJ",
                    Min = 6,
                    Max = 19,
                    DataPrevisao = new DateTime()
                },
                new WeatherForecast() {
                    Cidade = "São Paulo/SP",
                    Min = 6,
                    Max = 19,
                    DataPrevisao = new DateTime()
                }
            };
            ViewData["Top3Coldest"] = new List<WeatherForecast>() {
                new WeatherForecast() {
                    Cidade = "Petrópolis/RJ",
                    Min = 6,
                    Max = 19,
                    DataPrevisao = new DateTime()
                },
                new WeatherForecast() {
                    Cidade = "São Paulo/SP",
                    Min = 6,
                    Max = 19,
                    DataPrevisao = new DateTime()
                }
            };

            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
