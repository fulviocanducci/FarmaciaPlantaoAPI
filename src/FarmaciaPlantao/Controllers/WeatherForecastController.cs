using FarmaciaPlantao.API.Interface;
using FarmaciaPlantao.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private FarmaciaRepository _farmaciaRepository;


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, FarmaciaRepository farmaciaRepository)
        {
            _logger = logger;
            _farmaciaRepository = farmaciaRepository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var farmacia = new Farmacia() { Nome = "Teste", CEP = "19030440" };

            try
            {
                _farmaciaRepository.Add(farmacia);
            }
            catch (Exception e)
            {

                throw;
            }

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
