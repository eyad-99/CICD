using Microsoft.AspNetCore.Mvc;

namespace CICD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE", "EEEEEE","EEEEEE","EEEEEE","EEEEEE"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 11).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
