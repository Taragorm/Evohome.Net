using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class TemperatureStatus
    {
        [JsonPropertyName("temperature")]
        public double Temperature
        {
            get;
            set;
        }
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable
        {
            get;
            set;
        }
    }
}