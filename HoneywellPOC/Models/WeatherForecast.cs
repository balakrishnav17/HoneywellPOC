using System;

namespace HoneywellPOC
{
    public class WeatherForecast
    {
        public Response getTemperatureByCity(string city)
        {
            var rng = new Random();
            return new Response
            {
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20, 55),
                City = city

            };
        }
    }

    public class Response
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string City { get; set; }
    }

}
