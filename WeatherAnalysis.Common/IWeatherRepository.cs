namespace WeatherAnalysis.Common
{
    public interface IWeatherRepository
    {
        // Define data access methods
        Task<IEnumerable<WeatherDataDTO>> GetAllWeatherDataAsync();
        Task<WeatherDataDTO> GetWeatherDataByDateAsync(DateTime date);
        Task SaveWeatherDataAsync(IEnumerable<WeatherDataDTO> data);
    }
}
