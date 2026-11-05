using Newtonsoft.Json;
using System.Collections.Generic;

namespace Evohome.Lib
{
    public class GatewayStatus
    {
        [JsonProperty("gatewayId")]
        public string GatewayId
        {
            get;
            set;
        }
        [JsonProperty("temperatureControlSystems")]
        public List<TemperatureControlSystemStatus> TemperatureControlSystems
        {
            get;
            set;
        }
        [JsonProperty("activeFaults")]
        public List<string> ActiveFaults
        {
            get;
            set;
        }
    }
}