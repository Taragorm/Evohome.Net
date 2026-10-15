using System.Text.Json.Serialization;

namespace Evohome.Lib
{
    public class HeatSetpointStatus
    {
        [JsonPropertyName("targetTemperature")]
        public double TargetTemperature
        {
            get;
            set;
        }

        [JsonPropertyName("setpointMode")]
        public string SetpointMode
        {
            get;
            set;
        }
    }
}