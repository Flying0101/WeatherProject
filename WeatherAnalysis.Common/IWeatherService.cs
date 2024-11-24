namespace WeatherAnalysis.Common
{
    public interface IWeatherService
    {
        // Define business logic methods
        Task<decimal> CalculateAverageTemperatureAsync(DateTime date);
        Task<DateTime> DetermineAutumnStartAsync();
        Task<DateTime> DetermineWinterStartAsync();
        Task<decimal> CalculateMoldRiskAsync(DateTime date);
    }
}
