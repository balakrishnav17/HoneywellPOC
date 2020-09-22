using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        public WeatherForecast Weather { get; }
        public WeatherController(WeatherForecast weather)
        {
            Weather = weather;
        }

        [HttpPost("temperatureByCity")]
        public IActionResult TemperatureByCity(string city)
        {
            if (city == null)
                return NoContent();

            var result = Weather.getTemperatureByCity(city);
            return Ok(result);

        }
    }
}
