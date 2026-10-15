using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class GatewayStatus
    {
        [JsonPropertyName("gatewayId")]
        public string GatewayId
        {
            get;
            set;
        }
        [JsonPropertyName("temperatureControlSystems")]
        public List<TemperatureControlSystemStatus> TemperatureControlSystems
        {
            get;
            set;
        }
        [JsonPropertyName("activeFaults")]
        public List<string> ActiveFaults
        {
            get;
            set;
        }
    }
}