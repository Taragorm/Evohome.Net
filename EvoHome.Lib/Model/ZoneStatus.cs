using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class ZoneStatus
    {
        [JsonPropertyName("zoneId")]
        public string ZoneId
        {
            get;
            set;
        }
        [JsonPropertyName("temperatureStatus")]
        public TemperatureStatus TemperatureStatus
        {
            get;
            set;
        }

        [JsonPropertyName("activeFaults")]
        public List<ActiveFault> ActiveFaults
        {
            get;
            set;
        }

        [JsonPropertyName("heatSetpointStatus")]
        public HeatSetpointStatus HeatSetpointStatus
        {
            get;
            set;
        }
        [JsonPropertyName("name")]
        public string Name
        {
            get;
            set;
        }
    }
}