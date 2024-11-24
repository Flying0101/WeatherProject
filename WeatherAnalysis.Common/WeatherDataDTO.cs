namespace WeatherAnalysis.Common
{
    public class WeatherDataDTO
    {
        // Properties for transferring weather data between layers
        public DateTime Date { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
    }

}
