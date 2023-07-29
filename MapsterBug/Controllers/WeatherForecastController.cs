using Mapster;
using MapsterBug.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MapsterBug.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast GetOrigial()
    {
        return GenerateData();
    }

    [HttpGet("GetWeatherForecastDto1")]
    public DtoV1 GetDto1()
    {
        var data = GenerateData();
        return data.Adapt<DtoV1>();
    }

    [HttpGet("GetWeatherForecastDto2")]
    public DtoV2 GetDto2()
    {
        var data = GenerateData();
        return data.Adapt<DtoV2>();
    }

    private WeatherForecast GenerateData()
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            AreaCoordinates = new AreaCoordinates(
                Random.Shared.NextDouble().ToString(),
                Random.Shared.NextDouble().ToString(),
                Random.Shared.NextDouble().ToString(),
                Random.Shared.NextDouble().ToString()
                )
        };
    }
}

