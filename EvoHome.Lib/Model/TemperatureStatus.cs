using Newtonsoft.Json;

namespace Evohome.Lib
{
    public class TemperatureStatus
    {
        [JsonProperty("temperature")]
        public double Temperature
        {
            get;
            set;
        }
        [JsonProperty("isAvailable")]
        public bool IsAvailable
        {
            get;
            set;
        }
    }
}