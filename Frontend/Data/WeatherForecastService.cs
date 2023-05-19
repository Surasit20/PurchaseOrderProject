namespace Frontend.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public static Task<WeatherForecast[]> GetForecastAsync(WeatherForecast weatherForecast)
        {
        
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = weatherForecast.Id,
            }).ToArray());
        }
    }
}