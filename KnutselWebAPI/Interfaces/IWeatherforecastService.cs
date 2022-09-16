using KnutselWebAPI.Models;

namespace KnutselWebAPI.Interfaces
{
    public interface IWeatherforecastService
    {
        public IEnumerable<WeatherForecast> Get();
    }
}
