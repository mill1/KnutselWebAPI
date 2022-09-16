using KnutselWebAPI.Interfaces;
using KnutselWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KnutselWebAPI
{
	[ApiController]
	// [ApiVersion("2")]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class WeatherForecastController : ControllerBase
	{
        private readonly IWeatherforecastService _weatherforecastService;
        private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(IWeatherforecastService weatherforecastService, ILogger<WeatherForecastController> logger)
		{
            _weatherforecastService = weatherforecastService;
            _logger = logger;
		}

		[HttpGet]
		//[ApiVersion("1")]
		//[ApiVersion("2")]
		public IActionResult Get()
		{
			// for example: https://localhost:7231/api/v2/weatherforecast
			
			var result = _weatherforecastService.Get();

			return Ok(result);
		}

		[HttpGet("test")]
		// TODO. Let op: als je ApiVersion attr. mbt één method gebruikt moeten de andere methods ook er van voorzien worden
		public IActionResult Test()
		{
			// Test: https://localhost:7231/api/v2/weatherforecast/test
			return Ok("Test");
		}
	}
}